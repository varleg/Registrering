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
        [Required(ErrorMessage = "Vi må vite om du skal overnatte.")]
        public int Accomodation { get; set; }
        [Required(ErrorMessage = "Av statistiske grunner trenger vi din clean-dato.")]
        public DateTime SpecialDate { get; set; }
        [Required(ErrorMessage = "Du må velge en hjemmegruppe. " +
            "Dersom du ikke har en, velg et område (spør en i registreringa for å finne det du hører til) og 'Annet' i feltet  for gruppe.")]
        public Mote homeGroup { get; set; }
    }
}
