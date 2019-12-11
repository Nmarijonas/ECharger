using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Vertinimas
    {
        public double Reitingas { get; set; }
        public DateTime Data { get; set; }
        public int IdVertinimas { get; set; }
        public int FkAiksteleidAikstele { get; set; }
        public int FkKlientasidKlientas { get; set; }

        public Aikstele FkAiksteleidAiksteleNavigation { get; set; }
        public Klientas FkKlientasidKlientasNavigation { get; set; }
    }
}
