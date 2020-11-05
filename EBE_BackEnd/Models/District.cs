using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class District
    {
        private int id, city_Id;
        private string name;

        public District() { }
        public District(int id, int city_Id, string name)
        {
            this.id = id;
            this.city_Id = city_Id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public int City_Id { get => city_Id; set => city_Id = value; }
        public string Name { get => name; set => name = value; }
    }
}
