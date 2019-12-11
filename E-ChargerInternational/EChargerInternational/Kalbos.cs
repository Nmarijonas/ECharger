using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Kalbos
    {
        public Kalbos()
        {
            Kalba = new HashSet<Kalba>();
        }

        public int IdKalbos { get; set; }
        public string Name { get; set; }

        public ICollection<Kalba> Kalba { get; set; }
    }
}
