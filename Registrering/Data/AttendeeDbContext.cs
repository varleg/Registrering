using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registrering.Models;
using Microsoft.Extensions.Configuration;

namespace Registrering.Data
{
    public class AttendeeDbContext : DbContext
    {
        public AttendeeDbContext(DbContextOptions<AttendeeDbContext> options)
        : base(options)
        { }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Mote> Moter { get; set; }
    }
}
