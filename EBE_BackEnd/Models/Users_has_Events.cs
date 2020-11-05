using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Users_has_Events
    {
        private int id, User_Id, Events_id;
        private bool Confirmated;
        
        public Users_has_Events() { }
        public Users_has_Events(int id, int user_Id, int events_id, bool confirmated)
        {
            this.id = id;
            User_Id = user_Id;
            Events_id = events_id;
            Confirmated = confirmated;
        }

        public int Id { get => id; set => id = value; }
        public int User_Id1 { get => User_Id; set => User_Id = value; }
        public int Events_id1 { get => Events_id; set => Events_id = value; }
        public bool Confirmated1 { get => Confirmated; set => Confirmated = value; }
    }
}
