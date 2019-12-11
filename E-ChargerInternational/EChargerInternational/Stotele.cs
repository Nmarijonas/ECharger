using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Stotele
    {
        public int Galia { get; set; }
        public int Numeris { get; set; }
        public decimal ValandinisMokestis { get; set; }
        public string Aprasymas { get; set; }
        public int IdStotele { get; set; }
        public int FkAiksteleidAikstele { get; set; }

        public Aikstele FkAiksteleidAiksteleNavigation { get; set; }
    }
}
