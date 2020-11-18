using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class City
    {
        private int id, state_Id;
        private string name;

        public City() { }
        public City(int id, int state_Id, string name)
        {
            this.id = id;
            this.state_Id = state_Id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public int State_Id { get => state_Id; set => state_Id = value; }
        public string Name { get => name; set => name = value; }
    }
}
