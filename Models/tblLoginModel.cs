using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CRUD_MVC_Demo_100524.Models
{
    public class tblLoginModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="User ID")]
        public string userId { get; set; }
        [Required]
        public string password { get; set; }
    }
}