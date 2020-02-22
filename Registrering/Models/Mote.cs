using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Registrering.Models
{
    public class Mote
    {
        [Key]
        public int Id { get; set; }
        public string Committee { get; set; }
        public string CommitteeName { get; set; }
        public string AddDate { get; set; }
        public string AreaRegion { get; set; }
        public string ParentName { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public string Field16 { get; set; }
        public string Field17 { get; set; }
        public string Field18 { get; set; }
        public string Field25 { get; set; }
        public string Field26 { get; set; }
        public string Field27 { get; set; }
        public string Field36 { get; set; }
        public string Format1 { get; set; }
        public string Format2 { get; set; }
        public string Format3 { get; set; }
        public string Format4 { get; set; }
        public string Format5 { get; set; }
        public string Room { get; set; }
        public string Closed { get; set; }
        public string WheelChr { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Language1 { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string LocBorough { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public string Directions { get; set; }
        public string Delete { get; set; }
        public string LastChanged { get; set; }
        public decimal longitude { get; set; }
        public decimal latitude { get; set; }
        public string ContactGP { get; set; }

    }
}
