using Microsoft.EntityFrameworkCore;
using Registrering.Data;
using Registrering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrering.Services
{
    public class AttendeeService : IAttendeeService
    {
        private readonly AttendeeDbContext _context;
        public AttendeeService(AttendeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<Attendee>> Get()
        {
            return await _context.Attendees.ToListAsync();
        }

        public async Task<Attendee> Get(int id)
        {
            var attendee = await _context.Attendees.FindAsync(id);
            return attendee;
        }

        public async Task<Attendee> Add(Attendee attendee)
        {
            _context.Attendees.Add(attendee);
            await _context.SaveChangesAsync();
            return attendee;
        }

        public async Task<Attendee> Update(Attendee attendee)
        {
            _context.Entry(attendee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return attendee;
        }

        public async Task<Attendee> Delete(int id)
        {
            var attendee = await _context.Attendees.FindAsync(id);
            _context.Attendees.Remove(attendee);
            await _context.SaveChangesAsync();
            return attendee;
        }
        public async Task<List<Mote>> GetMoter()
        {
            return await _context.Moter.ToListAsync();
        }
        public async Task<Mote> GetMote(int id)
        {
            var mote = await _context.Moter.FindAsync(id);
            return mote;
        }
    }
}
