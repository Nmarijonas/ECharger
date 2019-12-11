using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Kalba
    {
        public Kalba()
        {
            Klientokalbos = new HashSet<Klientokalbos>();
        }

        public int Kalba1 { get; set; }
        public int IdKalba { get; set; }

        public Kalbos Kalba1Navigation { get; set; }
        public ICollection<Klientokalbos> Klientokalbos { get; set; }
    }
}
