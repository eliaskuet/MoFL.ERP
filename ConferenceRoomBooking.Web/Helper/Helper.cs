using BusinessAL.DbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ConferenceRoomBooking.Web.Helper
{
    public static class WebHelper
    {
        public static List<SelectListItem> GetChairPerson(RepositoryContext _context, int? selectedValue = null)
        {
            var items = _context.Chairperson.Select
                (
                    c => new SelectListItem
                    {
                        Value = c.ChairpersonId.ToString(),
                        Text = string.IsNullOrWhiteSpace(c.ShortDescription) ? c.ChairpersonName : c.ChairpersonName + " (" + c.ShortDescription + ")"
                    }
                ).ToList();
            if (selectedValue != null)
                items.FirstOrDefault(items => items.Value == selectedValue.ToString()).Selected = true;
            return items;
        }
    }
}
