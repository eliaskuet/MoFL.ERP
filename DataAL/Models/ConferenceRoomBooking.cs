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
    #region Conference Room Booking System

    public class ConferenceRoomBooking : BaseEntity
    {
        public int ConferenceRoomBookingId { get; set; }
        [Required(ErrorMessage = "অনুষ্ঠানের তারিখ প্রদান করুন।")]
        [Display(Name = "শুরুর সময়")]
        public DateTime DateOfEvent { get; set; }
        [Required(ErrorMessage = "অনুষ্ঠানের সময় প্রদান করুন।")]
        [Display(Name = "সময়")]
        public string StartTime { get; set; }
        [Required(ErrorMessage = "অনুষ্ঠানের বিষয় প্রদান করুন।")]
        [Display(Name = "বিষয়")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "অনুষ্ঠানের ধরণ বাছাই করুন।")]
        [Display(Name = "অনুষ্ঠানের ধরণ")]
        [ForeignKey("EventType")]
        public int EventTypeId { get; set; }
        [Display(Name = "মন্তব্য / বিবরণ")]
        public string Description { get; set; }
        [Required(ErrorMessage = "আহ্বায়ক / সভাপতি বাছাই করুন।")]
        [Display(Name = "আহ্বায়ক / সভাপতি")]
        [ForeignKey("Chairperson")]
        public int ChairpersonId { get; set; }
        [Display(Name = "আহ্বায়ক / সভাপতির নাম")]
        public string ChairPersonName { get; set; }
        [Display(Name = "আহ্বায়ক / সভাপতির পদবী")]
        public string ChairPersonDesignation { get; set; }
        [Required(ErrorMessage = "সম্ভাব্য শেষ সময় প্রদান করুন।")]
        [Display(Name = "সম্ভাব্য শেষ সময়")]
        public DateTime TentativeEndTime { get; set; }

        [Display(Name = "যোগাযোগের ব্যক্তির নাম")]
        public string ContactPersonaName { get; set; }
        [Display(Name = "যোগাযোগের ব্যক্তির মোবাইল")]
        public string ContactPersonMobile { get; set; }
        [Display(Name = "নোটিশ / ডকুমেন্ট")]
        public string OfficeOrderUrl { get; set; }
        [Display(Name = "নোটিশ / ডকুমেন্টের নাম")]
        public string OriginalName { get; set; }

        [Required(ErrorMessage = "দপ্তর / কার্যালয় বাছাই করুন।")]
        [Display(Name = "দপ্তর / কার্যালয়")]
        [ForeignKey("Office")]
        public int OfficeId { get; set; }
        
        [Display(Name = "Zoom Meeting Id")]
        public string ZoomMeetingId { get; set; }
        [Display(Name = "Zoom Meeting Passcode")]
        public string ZoomMeetingPasscode { get; set; }
        [Display(Name = "Zoom Meeting Link")]
        public string ZoomMeetingLink { get; set; }

        public virtual Chairperson Chairperson { get; set; }
        public virtual Office Office { get; set; }
        public virtual EventType EventType { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "অনুষ্ঠানের তারিখ প্রদান করুন।")]
        [Display(Name = "নতুন তারিখ")]
        public DateTime? NewDateOfEvent { get; set; }
    }

    #endregion

    #region Meta for Conference Room Booking
    public class Chairperson: BaseEntity
    {
        public int ChairpersonId { get; set; }
        [Required(ErrorMessage = "আহ্বায়ক / সভাপতি নাম প্রদান করুন।")]
        [Display(Name = "আহ্বায়ক / সভাপতি")]
        public string ChairpersonName { get; set; }
        //[Required(ErrorMessage = "দপ্তর / কার্যালয় বাছাই করুন।")]
        //[Display(Name = "দপ্তর / কার্যালয়")]
        //public int OfficeId { get; set; }
        //public virtual Office Office { get; set; }
        [Display(Name = "পদবী")]
        [ForeignKey("Designation")]
        [Required(ErrorMessage = "পদবী বাছাই করুন।")]
        public int DesignationId { get; set; }
        [Display(Name = "সংক্ষিপ্ত বিবরণ")]
        public string ShortDescription { get; set; }        
        [Display(Name = "অফিসিয়াল ইমেইল")]
        public string OfficialEmail { get; set; }
        [Display(Name = "মোবাইল")]
        public string Mobile { get; set; }
        [Display(Name = "গুগল ইমেইল")]
        public string GoogleEmail { get; set; }

        [Required(ErrorMessage = "ক্রম নম্বর প্রদান করুন।")]
        [Display(Name = "Sequence")]
        public int Sequence { get; set; }
        public virtual Designation Designation { get; set; }
    }
    #endregion
}
