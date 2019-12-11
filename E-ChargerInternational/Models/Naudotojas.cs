using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EChargerInternational.Models
{
    public class Naudotojas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime GimimoData { get; set; }
        public string Telefonas { get; set; }
        public string EPastas { get; set; }
        public string AsmensKodas { get; set; }
        public bool Busena { get; set; }
        public string Aprasymas { get; set; }
        public int RoleId { get; set; }
    }
}

