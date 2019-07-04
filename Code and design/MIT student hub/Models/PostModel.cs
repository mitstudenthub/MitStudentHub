using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MIT_student_hub.Models
{
    public class PostModel
    {
        //To change label title value  
        [DisplayName("Post")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can not be empty.")]
        public string PostMessage { get; set; }

        public IFormFile ImageFile { get; set; }
        public string Imagebase64 { get; set; }

    }

    public class UserDataModel
    {
        public int Postid { get; set; }
        public string MessageString { get; set; }
        public string PostImage { get; set; }
        public string Userid { get; set; }
        public string Userimage { get; set; }
        public List<CommentDataModel> Comments { get; set; }
    }
    public class commentpost
    {
        public int Postid4comment { get; set; }
        public string Userid4comment { get; set; }
        public string commentmessage { get; set; }
    }
    public class CommentDataModel
    {
        public int Commentid { get; set; }
        public string commentcreationDate { get; set; }
        public string commenttext { get; set; }
        public string commentuserimage { get; set; }
    }
}
