using DataAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAL.SeedData
{

    public static partial class SeedData
    {
        #region DocumentMSDataSeed

        public static List<FileType> FileTypes 
        {
            get
            {
                return new List<FileType>
                {
                    new FileType { FileTypeId = 1, TypeName = "PDF", FileExtension = ".pdf", Description = "Portable Document Format" },
                    new FileType { FileTypeId = 2, TypeName = "Word Document", FileExtension = ".docx", Description = "Microsoft Word Document" },
                    new FileType { FileTypeId = 3, TypeName = "Excel Spreadsheet", FileExtension = ".xlsx", Description = "Microsoft Excel Spreadsheet" },
                    new FileType { FileTypeId = 4, TypeName = "PowerPoint Presentation", FileExtension = ".pptx", Description = "Microsoft PowerPoint Presentation" },
                    new FileType { FileTypeId = 5, TypeName = "Text File", FileExtension = ".txt", Description = "Plain Text File" },
                    new FileType { FileTypeId = 6, TypeName = "Image File", FileExtension = ".jpg/.png/.gif", Description = "Image Files (JPEG, PNG, GIF)" }
                };
            }
        }

        public static List<DocumentCategory> DocumentCategories
        { 
            get
            {
                return new List<DocumentCategory>
                {
                    new DocumentCategory { DocumentCategoryId = 1, CategoryName = "চিঠি", Description = "সরকারি বা ব্যক্তিগত চিঠিপত্র" },
                    new DocumentCategory { DocumentCategoryId = 2, CategoryName = "রিপোর্ট", Description = "বিভিন্ন ধরনের রিপোর্ট" },
                    new DocumentCategory { DocumentCategoryId = 3, CategoryName = "ফর্ম", Description = "আবেদন ফর্ম বা অন্যান্য ফর্ম" },
                    new DocumentCategory { DocumentCategoryId = 4, CategoryName = "প্রেজেন্টেশন", Description = "PowerPoint বা অন্যান্য প্রেজেন্টেশন ফাইল" },
                    new DocumentCategory { DocumentCategoryId = 5, CategoryName = "মেমো", Description = "মেমো বা নোটিশ" },
                    new DocumentCategory { DocumentCategoryId = 6, CategoryName = "অন্যান্য", Description = "অন্যান্য ধরনের ডকুমেন্ট" }
                };
            }
        }
        #endregion
    }
}
