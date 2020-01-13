using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registrering.Models
{
    public class Attendee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Accomodation { get; set; }

        public DateTime SpecialDate { get; set; }

    }
}
