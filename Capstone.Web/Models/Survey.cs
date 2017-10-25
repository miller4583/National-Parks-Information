using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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

        public static List<SelectListItem> parkCodes { get; } = new List<SelectListItem>()
        {
            new SelectListItem(){Text ="Cuyahoga Valley National Park", Value = "CVNP" },
            new SelectListItem(){Text ="Everglades National Park", Value = "ENP" },
            new SelectListItem(){Text ="Grand Canyon National Park", Value = "GCNP" },
            new SelectListItem(){Text ="Glacier National Park", Value = "GNP" },
            new SelectListItem(){Text ="Great Smoky Mountains National Park", Value = "GSMNP" },
            new SelectListItem(){Text ="Grand Teton National Park", Value = "GTNP" },
            new SelectListItem(){Text ="Mount Rainier National Park", Value = "MRNP" },
            new SelectListItem(){Text ="Rocky Mountain National Park", Value = "RMNP" },
            new SelectListItem(){Text ="Yellowstone National Park", Value = "YNP" },
            new SelectListItem(){Text ="Yosemite National Park", Value = "YNP2" },


        };

    }
}