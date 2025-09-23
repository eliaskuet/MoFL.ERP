using DataAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Models
{
    public class PersonalInformation: BaseEntity
    {
        [Key]
        public int PersonalInformationId { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required]
        [ForeignKey("Designation")]
        [Display(Name ="Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

        [Required]
        [ForeignKey("Office")]
        [Display(Name = "Office")]
        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }

        [Required]
        [ForeignKey("Degree")]
        [Display(Name = "Latest Degree")]
        public int DegreeId { get; set; }
        public virtual Degree Degree { get; set; }

        [Required(ErrorMessage = "Personal Mobile is required")]
        [Display(Name = "Mobile (Personal)")]
        public string MobilePersonal { get; set; }
        [Display(Name = "Mobile (Official)")]
        public string MobileOfficial { get; set; }

        [Required(ErrorMessage = "Personal Email is required")]
        [Display(Name = "Email (Personal)")]
        public string EmailPersonal { get; set; }
        [Display(Name = "Email (Official)")]
        public string EmailOfficial { get; set; }
        [Display(Name = "Service Id")]
        public string ServiceId { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Login User")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Login User")]
        public int? LoginUserId { get; set; }
    }
}
