using DataAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Models
{
    #region Common


    //public class Nationality : BaseMasterEntity
    //{
    //    [Required]
    //    [Display(AutoGenerateField = false)]
    //    [Key]
    //    public int NationalityId { get; set; }

    //    [Required(ErrorMessage = "Nationality নাম প্রদান করুন।")]
    //    [StringLength(256)]
    //    [Display(Name = "Nationality")]
    //    public string Name { get; set; }
    //}

    public class Country : BaseMasterEntity
    {
        [Required]
        [Key]
        public int CountryId { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Country")]
        public string Name { get; set; }

        [StringLength(16)]
        [Display(Name = "Ticker")]
        public string CountryTicker { get; set; }

        [StringLength(8)]
        [Display(Name = "Phone Code")]
        public string PhoneCode { get; set; }
        public virtual IEnumerable<State> States { get; set; }
    }

    public class State : BaseMasterEntity
    {
        [Required]
        [Key]
        public int StateId { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

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
    }

    public class City : BaseMasterEntity
    {
        [Required]
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "City")]
        public string Name { get; set; }

        [Display(Name = "Country")]
        //[ForeignKey("Country")]
        public int CountryId { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        public int StateId { get; set; }

        public virtual State State { get; set; }
        //public virtual Country Country { get; set; }
        public virtual IEnumerable<Locality> Localities { get; set; }
    }

    public class Locality : BaseMasterEntity
    {
        [Required]
        [Key]
        public int LocalityId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Division")]
        public int StateId { get; set; }

        [ForeignKey("City")]
        [Display(Name = "District")]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }

    //public class BloodGroup : BaseMasterEntity
    //{
    //    [Required]
    //    [Key]
    //    public int BloodGroupId { get; set; }

    //    [Required]
    //    [StringLength(64)]
    //    [Display(Name = "Blood Group")]
    //    public string Name { get; set; }

    //}

    public class Gender : BaseMasterEntity
    {
        [Required]
        [Key]
        public int GenderId { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Gender")]
        public string Name { get; set; }
    }

    //public class Religion : BaseMasterEntity
    //{
    //    [Required]
    //    [Key]
    //    public int ReligionId { get; set; }

    //    [Required]
    //    [StringLength(128)]
    //    [Display(Name = "Religion")]
    //    public string Name { get; set; }
    //}

    //public class MaritalStatus : BaseMasterEntity
    //{
    //    [Required]
    //    [Key]
    //    public int MaritalStatusId { get; set; }

    //    [Required]
    //    [StringLength(128)]
    //    [Display(Name = "Marital Status")]
    //    public string Name { get; set; }
    //}

    public class Designation : BaseMasterEntity
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int DesignationId { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sequence")]
        public int Order { get; set; }
    }

    public class Section : BaseMasterEntity
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int SectionId { get; set; }

        [Required]
        [Display(Name = "Section")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sequence")]
        public int Order { get; set; }
    }

    public class Office : BaseMasterEntity
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Moto { get; set; }
        [Display(Name = "Logo")]
        [DefaultValue("~/assets/images/bd-logo.png")]
        public string LogoUrl { get; set; }
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
        [ForeignKey("ParentOffice")]
        public int? ParentOfficeId { get; set; }
        public Office ParentOffice { get; set; }
        [Display(Name = "Sequence")]
        public int? Order { get; set; }
    }

    //public class SalaryGrade : BaseMasterEntity
    //{
    //    [Required]
    //    [Display(AutoGenerateField = false)]
    //    [Key]
    //    public int SalaryGradeId { get; set; }
    //    [Display(Name = "Salary Grade")]
    //    public string Name { get; set; }
    //    [Display(Name = "Sequence")]
    //    public int Order { get; set; }
    //}

    //public class DivisionOrClass : BaseMasterEntity
    //{
    //    [Required]
    //    [Display(AutoGenerateField = false)]
    //    [Key]
    //    public int DivisionOrClassId { get; set; }
    //    [Display(Name = "ডিভিশন/ক্লাস")]
    //    public string Name { get; set; }
    //    [Display(Name = "Sequence")]
    //    public int Order { get; set; }
    //}

    //public class Language : BaseMasterEntity
    //{
    //    [Required]
    //    [Display(AutoGenerateField = false)]
    //    [Key]
    //    public int LanguageId { get; set; }
    //    [Display(Name = "Language")]
    //    public string Name { get; set; }
    //    [Display(Name = "Sequence")]
    //    public int Order { get; set; }
    //}

    public class Degree : BaseMasterEntity
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int DegreeId { get; set; }
        [Display(Name = "ডিগ্রি")]
        public string Name { get; set; }
        [Display(Name = "Sequence")]
        public int Order { get; set; }
    }

    #region Event Related

    public class EventType : BaseMasterEntity
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public int EventTypeId { get; set; }
        [Display(Name = "ইভেন্ট টাইপ")]
        public string Name { get; set; }
        [Display(Name = "Sequence")]
        public int Order { get; set; }
    }

    #endregion

    #endregion
}
