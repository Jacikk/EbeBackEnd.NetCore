using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Manager
    {
        private int id, events_id, user_id;
        public Manager () { }
        public Manager(int id, int events_id, int user_id)
        {
            this.id = id;
            this.events_id = events_id;
            this.user_id = user_id;
        }

        public int Id { get => id; set => id = value; }
        public int Events_id { get => events_id; set => events_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
    }
}
