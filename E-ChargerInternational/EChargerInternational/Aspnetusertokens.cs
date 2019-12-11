using System;
using System.Collections.Generic;

namespace EChargerInternational.EChargerInternational
{
    public partial class Aspnetusertokens
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Aspnetusers User { get; set; }
    }
}
