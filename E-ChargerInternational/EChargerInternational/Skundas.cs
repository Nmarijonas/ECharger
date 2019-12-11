using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Skundas
    {
        public string Aprasymas { get; set; }
        public DateTime Data { get; set; }
        public int Busena { get; set; }
        public int IdSkundas { get; set; }
        public int FkKlientasidKlientas { get; set; }
        public int FkKlientasidKlientas1 { get; set; }

        public SkundoBusena BusenaNavigation { get; set; }
        public Klientas FkKlientasidKlientas1Navigation { get; set; }
        public Klientas FkKlientasidKlientasNavigation { get; set; }
    }
}
