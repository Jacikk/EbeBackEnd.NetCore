using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Street
    {
        private int id, district_Id, cEP;
        private string name;

        public Street() { }

        public Street(int id, int district_Id, int cEP, string name)
        {
            this.id = id;
            this.district_Id = district_Id;
            this.cEP = cEP;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public int District_Id { get => district_Id; set => district_Id = value; }
        public int CEP { get => cEP; set => cEP = value; }
        public string Name { get => name; set => name = value; }
    }
}
