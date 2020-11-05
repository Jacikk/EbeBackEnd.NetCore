using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Instituiton
    {
        private int id, street_Id;
        private string name, cnpj, email, password, description, avatar, addressNumber, addressReference;

        public Instituiton() { }
        public Instituiton(int id, int street_Id, string name, string cnpj, string email, string password, string description, string avatar, string addressNumber, string addressReference)
        {
            this.id = id;
            this.street_Id = street_Id;
            this.name = name;
            this.cnpj = cnpj;
            this.email = email;
            this.password = password;
            this.description = description;
            this.avatar = avatar;
            this.addressNumber = addressNumber;
            this.addressReference = addressReference;
        }

        public int Id { get => id; set => id = value; }
        public int Street_Id { get => street_Id; set => street_Id = value; }
        public string Name { get => name; set => name = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Description { get => description; set => description = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string AddressNumber { get => addressNumber; set => addressNumber = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }
    }
}
