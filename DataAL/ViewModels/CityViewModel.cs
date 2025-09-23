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
    public class CityViewModel
    {

        [Required]
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "City")]
        public string Name { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        public int StateId { get; set; }

        public virtual State State { get; set; }
        public virtual Country Country { get; set; }
        public virtual IEnumerable<Locality> Localities { get; set; }

        public string StateName { get; set; }
        public string CountryName { get; set; }

        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
    }
}
