using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MIT_student_hub.Models;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MIT_student_hub.Controllers
{
    public class Job : Controller
    {
        IConfiguration _Iconfiguration;
        private string ConnectionString;
        public Job(IConfiguration iconfiguration)
        {
            _Iconfiguration = iconfiguration;
            ConnectionString = _Iconfiguration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            string user = HttpContext.Session.GetString("User");
            if (!string.IsNullOrEmpty(user))
            {
            PostModel _MainPost = new PostModel();
            SqlDataReader Jrdr;
            char jtype = 'J';
            List<UserDataModel> PostModelList = new List<UserDataModel>();
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand JCmd = new SqlCommand("GetJobsByUser", con);
                JCmd.CommandType = CommandType.StoredProcedure;
                JCmd.Parameters.Add(new SqlParameter("@Userid", user));
                JCmd.Parameters.Add(new SqlParameter("@Posttype", 'J'));
                Jrdr = JCmd.ExecuteReader();
                if (Jrdr.HasRows)
                {
                    while (Jrdr.Read())
                    {
                        UserDataModel _postmodel = new UserDataModel();
                        _postmodel.Postid = (int)Jrdr["Postid"];
                        _postmodel.MessageString = (string)Jrdr["Posttext"];
                        byte[] byt = (byte[])Jrdr["Postimage"];
                        _postmodel.Userid = (string)Jrdr["UserId"];
                        _postmodel.Userimage = (string)Jrdr["Userimage"];
                        _postmodel.PostImage = Convert.ToBase64String(byt);
                            //_postmodel.PostImage = (string)Jrdr["Postimage"];
                        _postmodel.Comments = GetCommentsByPost(Convert.ToInt32(Jrdr["Postid"]));
                            PostModelList.Add(_postmodel);
                    }
                    con.Close();

                }
                List<UserDataModel> listob = GetAllJobList();
                ViewData["AllJoblist"] = Convert.ToString(listob[0].MessageString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return View(PostModelList);
        }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }


       
        [HttpPost]
        public ActionResult PostForm(PostModel postvalues)
        {
            string Trimbase64 = string.Empty;
            if(!string.IsNullOrEmpty(postvalues.Imagebase64))
            {
                if (postvalues.Imagebase64.Contains("data:image"))
                {
                    if (postvalues.Imagebase64.Contains("data:image/jpeg;base64"))
                    {
                        Trimbase64 = postvalues.Imagebase64.Remove(0, 23);
                    }
                    else
                    {
                        Trimbase64 = postvalues.Imagebase64.Remove(0, 22);
                    }
                }
            }

           
            string userName = HttpContext.Session.GetString("User");
            if (!string.IsNullOrEmpty(userName))
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand dCmd = new SqlCommand("Update_Job_Post", con);
                    dCmd.CommandType = CommandType.StoredProcedure;
                    dCmd.Parameters.Add(new SqlParameter("@Userid", userName));
                    dCmd.Parameters.Add(new SqlParameter("@Posttext", postvalues.PostMessage));
                    dCmd.Parameters.Add(new SqlParameter("@PostImage", Base64ToImage(Trimbase64)));
                    object o = dCmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public ActionResult CommentPost(commentpost _commentpost)
        {
            if (!string.IsNullOrEmpty(_commentpost.commentmessage))
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand dCmd = new SqlCommand("Update_Post_Comment", con);
                    dCmd.CommandType = CommandType.StoredProcedure;
                    dCmd.Parameters.Add(new SqlParameter("@Userid4comment", _commentpost.Userid4comment));
                    dCmd.Parameters.Add(new SqlParameter("@commentmessage", _commentpost.commentmessage));
                    dCmd.Parameters.Add(new SqlParameter("@Postid4comment",Convert.ToInt32(_commentpost.Postid4comment)));
                    object o = dCmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return RedirectToAction("Index");
        }
        public byte[] Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            //MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
           
            //MemoryStream msArr = new MemoryStream();
            //image.Save(msArr, System.Drawing.Imaging.ImageFormat.Gif);
            return imageBytes;
        }
        public ActionResult ViewAlljobs()
        {
            List<UserDataModel> Listalljob = GetAllJobList();
            return View(Listalljob);
        }

        public List<UserDataModel> GetAllJobList()
        {
            SqlDataReader sqdr;
            List<UserDataModel> PostModelList = new List<UserDataModel>();
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand JCmdlist = new SqlCommand("GetAllJobPost", con);
                JCmdlist.CommandType = CommandType.StoredProcedure;
                sqdr = JCmdlist.ExecuteReader();
                if (sqdr.HasRows)
                {
                    while (sqdr.Read())
                    {
                        UserDataModel _postmodel = new UserDataModel();
                        _postmodel.Postid = (int)sqdr["Postid"];
                        _postmodel.MessageString = (string)sqdr["Posttext"];
                        byte[] byt = (byte[])sqdr["Postimage"];
                        _postmodel.Userid = (string)sqdr["UserId"];
                        _postmodel.Userimage = (string)sqdr["Userimage"];
                        _postmodel.PostImage = Convert.ToBase64String(byt);
                        //_postmodel.PostImage = (string)Jrdr["Postimage"];
                        _postmodel.Comments = GetCommentsByPost(Convert.ToInt32(sqdr["Postid"]));
                        PostModelList.Add(_postmodel);
                    }
                    con.Close();

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return PostModelList;
        }
        public List<CommentDataModel> GetCommentsByPost(int postid)
        {
            SqlDataReader sqdr;
            List<CommentDataModel> CommentDataModelList = new List<CommentDataModel>();
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand JCmdlist = new SqlCommand("GetAllPostComments", con);
                JCmdlist.CommandType = CommandType.StoredProcedure;
                JCmdlist.Parameters.Add(new SqlParameter("@Postid", postid));
                sqdr = JCmdlist.ExecuteReader();
                if (sqdr.HasRows)
                {
                    while (sqdr.Read())
                    {
                        CommentDataModel _commentmodel = new CommentDataModel();
                        _commentmodel.Commentid = (int)sqdr["Commentid"];
                        _commentmodel.commenttext = (string)sqdr["Commenttext"];
                        _commentmodel.commentuserimage = (string)sqdr["Userimage"];
                        _commentmodel.commentcreationDate = Convert.ToDateTime(sqdr["Creationdate"]).ToString("mm/dd/yyyy");
                        CommentDataModelList.Add(_commentmodel);
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return CommentDataModelList;
        }
    }
}
