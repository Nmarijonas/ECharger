using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Aikstele
    {
        public Aikstele()
        {
            Atsiliepimas = new HashSet<Atsiliepimas>();
            Stotele = new HashSet<Stotele>();
            Vertinimas = new HashSet<Vertinimas>();
        }

        public string Pavadinimas { get; set; }
        public string TelefonoNumeris { get; set; }
        public TimeSpan DarboPradzia { get; set; }
        public TimeSpan DarboPabaiga { get; set; }
        public byte Saugoma { get; set; }
        public decimal ElektrosKaina { get; set; }
        public decimal PapildomasMokestis { get; set; }
        public string PapildomoMokescioAprasymas { get; set; }
        public string Miestas { get; set; }
        public string Gatve { get; set; }
        public int NamoNr { get; set; }
        public decimal KoordinateX { get; set; }
        public decimal KoordinateY { get; set; }
        public string PastoKodas { get; set; }
        public string Aprasymas { get; set; }
        public int IdAikstele { get; set; }
        public int FkKlientasidKlientas { get; set; }

        public Klientas FkKlientasidKlientasNavigation { get; set; }
        public ICollection<Atsiliepimas> Atsiliepimas { get; set; }
        public ICollection<Stotele> Stotele { get; set; }
        public ICollection<Vertinimas> Vertinimas { get; set; }
    }
}
