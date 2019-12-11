using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class SkundoBusena
    {
        public SkundoBusena()
        {
            Skundas = new HashSet<Skundas>();
        }

        public int IdSkundoBusena { get; set; }
        public string Name { get; set; }

        public ICollection<Skundas> Skundas { get; set; }
    }
}
