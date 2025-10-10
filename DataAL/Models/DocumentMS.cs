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
    public class FileType : BaseMasterEntity
    {
        public int FileTypeId { get; set; }
        [Display(Name = "ফাইলের ধরন")]
        [Required(ErrorMessage = "ফাইলের ধরন প্রদান করুন।")]
        public string TypeName { get; set; }
        [Display(Name = "ফাইলের এক্সটেনশন")]
        [Required(ErrorMessage = "ফাইলের এক্সটেনশন প্রদান করুন।")]
        public string FileExtension { get; set; }
        [Display(Name = "বর্ণনা")]
        public string Description { get; set; }
    }

    public class DocumentCategory : BaseEntity
    {
        public int DocumentCategoryId { get; set; }
        [Display(Name = "ডকুমেন্টের ধরন")]
        [Required(ErrorMessage = "ডকুমেন্টের ধরন প্রদান করুন।")]
        public string CategoryName { get; set; }
        [Display(Name = "বর্ণনা")]
        public string Description { get; set; }
    }
    public class Document : BaseEntity
    {
        public int DocumentId { get; set; }
        [Display(Name = "ফাইলের নাম")]
        public string FileName { get; set; }
        [Display(Name = "ফাইলের মূল নাম")]
        public string OriginalName { get; set; }
        [Display(Name = "ফাইলের বর্ণনা")]
        public string Description { get; set; }
        [Display(Name = "ফাইলের আকার")]
        public long FileSize { get; set; }
        [Display(Name = "ফাইলের এক্সটেনশন")]
        public string FileExtension { get; set; }
        [Display(Name = "আপলোড করার সময়")]
        public DateTime UploadedAt { get; set; }
        [Display(Name = "ডকুমেন্টের ধরন")]
        [ForeignKey("DocumentCategory")]
        public int? DocumentTypeId { get; set; }
        [Display(Name = "দপ্তর / কার্যালয়")]
        [ForeignKey("Office")]
        public int OfficeId { get; set; }
        public virtual DocumentCategory DocumentType { get; set; }
        public virtual Office Office { get; set; }
    }
}
