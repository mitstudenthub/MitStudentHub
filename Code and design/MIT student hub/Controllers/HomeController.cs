using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIT_student_hub.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using System.Data;

namespace MIT_student_hub.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _Iconfiguration;
        private string ClientId;
        private string SecretKey;
        private string RedirectUrl;
        private string allowedDomain = "manukaumail.com";
        private string ConnectionString;
        public HomeController(IConfiguration  iconfiguration)
        {
            _Iconfiguration = iconfiguration;
            ClientId = _Iconfiguration.GetValue<string>("Google:ClientId");
            SecretKey = _Iconfiguration.GetValue<string>("Google:ClientSecret");
            RedirectUrl = _Iconfiguration.GetValue<string>("Google:RedirectUrl");
            ConnectionString= _Iconfiguration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
        public IActionResult Index()
        {
           
            string user = HttpContext.Session.GetString("User");
            if (!string.IsNullOrEmpty(user))
            {
                string userName = HttpContext.Session.GetString("UserName");
            string userImage = HttpContext.Session.GetString("UserImage");
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand dCmd = new SqlCommand("User_Unique", con);
                dCmd.CommandType = CommandType.StoredProcedure;
                dCmd.Parameters.Add(new SqlParameter("@Userid", user));
                dCmd.Parameters.Add(new SqlParameter("@UserName", userName));
                dCmd.Parameters.Add(new SqlParameter("@Userimage", userImage));
                object o = dCmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Hit Google API to get access code
        /// </summary>
        public void LoginUsingGoogle()
        {
            Response.Redirect($"https://accounts.google.com/o/oauth2/v2/auth?client_id={ClientId}&response_type=code&hd={allowedDomain}&scope=openid%20email%20profile&redirect_uri={RedirectUrl}&state=abcdef");
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            HttpContext.Session.SetString("User", string.Empty);
            return RedirectToAction("Login","Home");
        }

        /// <summary>
        /// Listen response from Google API after user authorization
        /// </summary>
        /// <param name="code">access code returned from Google API</param>
        /// <param name="state">A value passed by application to prevent Cross-site request forgery attack</param>
        /// <param name="session_state">session state</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> SaveGoogleUser(string code, string state, string session_state)
        {
            if (string.IsNullOrEmpty(code))
            {
                return View("Error");
            }

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.googleapis.com")
            };
            var requestUrl = $"oauth2/v4/token?code={code}&client_id={ClientId}&client_secret={SecretKey}&redirect_uri={RedirectUrl}&grant_type=authorization_code";

            var dict = new Dictionary<string, string>
            {
                { "Content-Type", "application/x-www-form-urlencoded" }
            };
            var req = new HttpRequestMessage(HttpMethod.Post, requestUrl) { Content = new FormUrlEncodedContent(dict) };
            var response = await httpClient.SendAsync(req);
            var token = JsonConvert.DeserializeObject<GmailToken>(await response.Content.ReadAsStringAsync());
            var obj = await GetuserProfile(token.AccessToken);

            //  HttpContext.Session.Set("User",Convert.ToString(obj.Email));
            HttpContext.Session.SetString("User", Convert.ToString(obj.Email));
            HttpContext.Session.SetString("UserName", Convert.ToString(obj.Name));
            HttpContext.Session.SetString("UserImage", Convert.ToString(obj.Picture));
            //IdToken property stores user data in Base64Encoded form
            //var data = Convert.FromBase64String(token.IdToken.Split('.')[1]);
            //var base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// To fetch User Profile by access token
        /// </summary>
        /// <param name="accesstoken">access token</param>
        /// <returns>User Profile page</returns>
        public async Task<UserProfile> GetuserProfile(string accesstoken)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.googleapis.com")
            };
            string url = $"https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token={accesstoken}";
            var response = await httpClient.GetAsync(url);
            return JsonConvert.DeserializeObject<UserProfile>(await response.Content.ReadAsStringAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
