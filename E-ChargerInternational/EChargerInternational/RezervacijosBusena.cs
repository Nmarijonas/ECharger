using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class RezervacijosBusena
    {
        public RezervacijosBusena()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int IdRezervacijosBusena { get; set; }
        public string Name { get; set; }

        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
