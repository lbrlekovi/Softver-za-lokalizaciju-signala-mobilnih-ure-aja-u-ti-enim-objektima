using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softver_za_lokalizaciju_signala.Models
{
    internal class Location
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int LokacijaX { get; set; }
        public int LokacijaY { get; set; }
    }
}
