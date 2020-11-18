using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Instituitions_has_Users
    {
        private int id, institution_Id, user_Id;
        public Instituitions_has_Users() { }
        public Instituitions_has_Users(int id, int institution_Id, int user_Id)
        {
            this.id = id;
            this.institution_Id = institution_Id;
            this.user_Id = user_Id;
        }

        public int Id { get => id; set => id = value; }
        public int Institution_Id { get => institution_Id; set => institution_Id = value; }
        public int User_Id { get => user_Id; set => user_Id = value; }
    }
}
