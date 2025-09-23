using DataAL.Models.BaseModels;
using DataAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataAL.ViewModels
{
    public class OfficeViewModel
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int OfficeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Moto { get; set; }
        [Display(Name = "Logo")]
        [DefaultValue("~/assets/images/bd-logo.png")]
        public string LogoUrl { get; set; }
        [Required]
        public string Address { get; set; }
        [Display(Name = "Live Link")]
        public string LiveUrl { get; set; }
        [Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }
        [Display(Name = "Contact Mobile")]
        public string ContactMobile { get; set; }
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }
        public bool IsCurrentOffice { get; set; }
        [Display(Name = "Parent Office")]
        public int? ParentOfficeId { get; set; }

        [Display(Name = "Parent Office")]
        public string ParentOfficeName { get; set; }

        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
    }
}
