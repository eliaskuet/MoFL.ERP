using BusinessAL.DbContext;
using BusinessAL.Repositories.BaseRepositories;
using DataAL.Models;
using DataAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.Repositories
{

    public class ConferenceRoomBookingRepository : BaseRepository<ConferenceRoomBooking>, IConferenceRoomBookingRepository
    {
        private readonly RepositoryContext _context;
        public ConferenceRoomBookingRepository(RepositoryContext _context)
            : base(_context)
        {
            this._context = _context;
        }
        public ConferenceRoomBooking GetById(int id)
        {
            var list =  _context.ConferenceRoomBooking.ToList();
            var obj = list.Where(i => i.ConferenceRoomBookingId == id).FirstOrDefault();
            return _context.ConferenceRoomBooking.Where(i => i.ConferenceRoomBookingId == id).FirstOrDefault(); ;
        }
    }

    public interface IConferenceRoomBookingRepository : IBaseRepository<ConferenceRoomBooking>
    {

    }
}
