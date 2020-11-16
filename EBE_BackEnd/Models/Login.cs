using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Login
    {
        private int id, userId;
        private string email, password;
        private string accessLevel;

        public Login() { }
        public Login(int id, int userId, string email, string password, string accessLevel)
        {
            this.id = id;
            this.userId = userId;
            this.email = email;
            this.password = password;
            this.accessLevel = accessLevel;
        }

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string AccessLevel { get => accessLevel; set => accessLevel = value; }
        ~Login()
        {
            Console.WriteLine("Login destructor was called. Open fire!");
        }
    }
   
}
