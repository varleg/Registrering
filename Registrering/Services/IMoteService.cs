using Registrering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrering.Services
{
    interface IMoteService
    {
        Task<List<Mote>> Get();
        Task<Mote> Get(int id);
    }
}
