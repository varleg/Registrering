using Microsoft.EntityFrameworkCore;
using Registrering.Data;
using Registrering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrering.Services
{
    public class MoteService : IMoteService
    {
        private readonly AttendeeDbContext _context;
        public MoteService(AttendeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<Mote>> Get()
        {
            return await _context.Moter.ToListAsync();
        }
        public async Task<Mote> Get(int id)
        {
            var mote = await _context.Moter.FindAsync(id);
            return mote;
        }
    }
}
