using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Klientokalbos
    {
        public int FkKalbaidKalba { get; set; }
        public int FkKlientasidKlientas { get; set; }

        public Kalba FkKalbaidKalbaNavigation { get; set; }
    }
}
