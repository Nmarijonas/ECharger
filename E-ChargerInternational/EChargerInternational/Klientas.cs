using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Klientas
    {
        public Klientas()
        {
            Aikstele = new HashSet<Aikstele>();
            Atsiliepimas = new HashSet<Atsiliepimas>();
            RezervacijaFkKlientasidGavejasNavigation = new HashSet<Rezervacija>();
            RezervacijaFkKlientasidSiuntejasNavigation = new HashSet<Rezervacija>();
            SkundasFkKlientasidKlientas1Navigation = new HashSet<Skundas>();
            SkundasFkKlientasidKlientasNavigation = new HashSet<Skundas>();
        }

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime GimimoData { get; set; }
        public string Telefonas { get; set; }
        public string Epastas { get; set; }
        public string AsmensKodas { get; set; }
        public string Role { get; set; }
        public byte Busena { get; set; }
        public string Slaptazodis { get; set; }
        public string Aprasymas { get; set; }
        public int IdKlientas { get; set; }
        public int FkRoleidRole { get; set; }

        public Role FkRoleidRoleNavigation { get; set; }
        public Vertinimas Vertinimas { get; set; }
        public ICollection<Aikstele> Aikstele { get; set; }
        public ICollection<Atsiliepimas> Atsiliepimas { get; set; }
        public ICollection<Rezervacija> RezervacijaFkKlientasidGavejasNavigation { get; set; }
        public ICollection<Rezervacija> RezervacijaFkKlientasidSiuntejasNavigation { get; set; }
        public ICollection<Skundas> SkundasFkKlientasidKlientas1Navigation { get; set; }
        public ICollection<Skundas> SkundasFkKlientasidKlientasNavigation { get; set; }
    }
}
