using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Rezervacija
    {
        public DateTime Pradzia { get; set; }
        public DateTime Pabaiga { get; set; }
        public DateTime SutartiesData { get; set; }
        public int Numeris { get; set; }
        public string Pranesimas { get; set; }
        public int Busena { get; set; }
        public int IdRezervacija { get; set; }
        public int FkKlientasidSiuntejas { get; set; }
        public int FkKlientasidGavejas { get; set; }

        public RezervacijosBusena BusenaNavigation { get; set; }
        public Klientas FkKlientasidGavejasNavigation { get; set; }
        public Klientas FkKlientasidSiuntejasNavigation { get; set; }
    }
}
