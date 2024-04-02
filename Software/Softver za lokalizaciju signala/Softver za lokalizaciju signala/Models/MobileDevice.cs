using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softver_za_lokalizaciju_signala.Models
{
    public class MobileDevice
    {
        public int Id { get; set; }
        public int Lokacija { get; set; }
        public int Vlasnik { get; set; }
        public bool Dozvoljen { get; set; }
    }
}
