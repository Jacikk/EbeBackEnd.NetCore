using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class State
    {
        private int id, country_Id;
        private string name;

        public State() { }
        public State(int id, int country_Id, string name)
        {
            this.id = id;
            this.country_Id = country_Id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public int Country_Id { get => country_Id; set => country_Id = value; }
        public string Name { get => name; set => name = value; }
    }
}
