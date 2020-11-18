using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class SubEvents
    {
        private int id, Events_id;
        private string name, description;
        private DateTime starting, ending;

        public SubEvents() { }
        public SubEvents(int id, int events_id, string name, string description, DateTime starting, DateTime ending)
        {
            this.id = id;
            Events_id = events_id;
            this.name = name;
            this.description = description;
            this.starting = starting;
            this.ending = ending;
        }

        public int Id { get => id; set => id = value; }
        public int Events_id1 { get => Events_id; set => Events_id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Starting { get => starting; set => starting = value; }
        public DateTime Ending { get => ending; set => ending = value; }
    }
}
