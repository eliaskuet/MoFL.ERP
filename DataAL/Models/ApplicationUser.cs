using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAL.Models.BaseModels;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace DataAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ApplicationUserId { get; set; }
        [Required]
        [StringLength(256)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        public string NothiId { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLoginDate { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Active?")]
        public bool IsPublished { get; set; }
        public int CreatedByUserId { get; set; }
        [Display(Name = "Added")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public int ModifiedById { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Modified")]
        public DateTime ModificationDate { get; set; }

        #region Not Mapped
        [NotMapped]
        public bool RememberMe { get; set; }

        #endregion
    }
}
