using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class SubEvents_has_Users
    {
        private int id, user_has_Events_Id, subevent_id, user_id;
        private bool confirmated;

        public SubEvents_has_Users() { }
        public SubEvents_has_Users(int id, int user_has_Events_Id, int subevent_id, int user_id, bool confirmated)
        {
            this.id = id;
            this.user_has_Events_Id = user_has_Events_Id;
            this.subevent_id = subevent_id;
            this.user_id = user_id;
            this.confirmated = confirmated;
        }

        public int Id { get => id; set => id = value; }
        public int User_has_Events_Id { get => user_has_Events_Id; set => user_has_Events_Id = value; }
        public int Subevent_id { get => subevent_id; set => subevent_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public bool Confirmated { get => confirmated; set => confirmated = value; }
    }
}
