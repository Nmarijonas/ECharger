using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Role
    {
        public Role()
        {
            Klientas = new HashSet<Klientas>();
        }

        public string Pavadinimas { get; set; }
        public byte Naudojama { get; set; }
        public int IdRole { get; set; }

        public ICollection<Klientas> Klientas { get; set; }
    }
}
