using DataAL.Models.BaseModels;
using DataAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.ViewModels
{
    public class StateViewModel
    {
        [Required]
        [Key]
        public int StateId { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        [Display(Name = "Country")]
        public string CountryName { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "State")]
        public string Name { get; set; }

        [StringLength(128)]
        [Display(Name = "Ticker")]
        public string StateTicker { get; set; }

        [Display(Name = "Default?")]
        public bool IsDefault { get; set; }

        public virtual Country Country { get; set; }
        public virtual IEnumerable<City> Cities { get; set; }

        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
    }
}
