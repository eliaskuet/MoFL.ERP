using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Models.BaseModels
{
    public class BaseEntity
    {
        [DefaultValue(true)]
        [Display(Name = "Active?")]
        public bool IsPublished { get; set; }
        public int CreatedByUserId { get; set; }
        [Display(Name = "Added by")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public int ModifiedById { get; set; }
        [Display(Name = "Modifier")]
        [DataType(DataType.Date)]
        public DateTime ModificationDate { get; set; }
    }
}
