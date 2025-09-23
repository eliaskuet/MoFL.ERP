using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Models.BaseModels
{
    public class BaseMasterEntity
    {
        [DefaultValue(true)]
        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
    }
}
