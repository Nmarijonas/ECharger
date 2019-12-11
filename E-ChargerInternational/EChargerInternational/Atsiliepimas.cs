using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Atsiliepimas
    {
        public string Aprasymas { get; set; }
        public DateTime Data { get; set; }
        public int IdAtsiliepimas { get; set; }
        public int FkKlientasidKlientas { get; set; }
        public int FkAiksteleidAikstele { get; set; }

        public Aikstele FkAiksteleidAiksteleNavigation { get; set; }
        public Klientas FkKlientasidKlientasNavigation { get; set; }
    }
}
