using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;


namespace Capstone.Web.Models
{
    public class Survey
    {


        public int SurveryId { get; set; }
        [Display(Name = "Please select park")]
        public string ParkCode { get; set; }
        [Display(Name = "Please enter your Email")]
        [Required(ErrorMessage ="Enter Email")]
        public string Email { get; set; }
        [Display(Name = "Your home state")]
        [Required(ErrorMessage = "Enter a State")]
        public string State { get; set; }
        [Display(Name = "How was the park?")]
        [Required(ErrorMessage = "Enter experience")]
        public string ActivityLevel { get; set; }
        public int Total { get; set; }
        public string ParkName { get; set; }



        public static List<SelectListItem> parkCodes { get; set; } = new List<SelectListItem>();
        
    }
}