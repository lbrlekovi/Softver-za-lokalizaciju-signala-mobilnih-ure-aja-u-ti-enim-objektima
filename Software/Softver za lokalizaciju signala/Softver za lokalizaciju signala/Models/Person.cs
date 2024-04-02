using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softver_za_lokalizaciju_signala.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojPrekrsaja { get; set; }
        public int Uloga { get; set; }
    }
}
