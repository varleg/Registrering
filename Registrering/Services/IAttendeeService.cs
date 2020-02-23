using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registrering.Models;

namespace Registrering.Services
{
    interface IAttendeeService
    {
        Task<List<Attendee>> Get();
        Task<Attendee> Get(int id);
        Task<Attendee> Add(Attendee attendee);
        Task<Attendee> Update(Attendee attendee);
        Task<Attendee> Delete(int id);
        Task<List<Mote>> GetMoter();
        Task<Mote> GetMote(int id);
    }
}
