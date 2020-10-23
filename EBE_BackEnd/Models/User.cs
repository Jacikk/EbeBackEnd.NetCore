using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{

    public class User
    {

        private int id, institution;
        private int addressNumber, addressId;
        private DateTime birthDate;
        private bool sex;

        private string accessLevel;

        private string
            name,
            cpf,
            rg,
            role,
            email,
            password,
            description,
            medicalCares,
            avatar,
            addressReference;

        public int Id { get => id; set => id = value; }
        public int Institution { get => institution; set => institution = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public int AddressId { get => addressId; set => addressId = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string AccessLevel { get => accessLevel; set => accessLevel = value; }
        public string Name { get => name; set => name = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Role { get => role; set => role = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Description { get => description; set => description = value; }
        public string MedicalCares { get => medicalCares; set => medicalCares = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }

        public User()
        {
        }

        public User(int id, int institution, int addressNumber, int addressId, DateTime birthDate, bool sex, string accessLevel, string name, string cpf, string rg, string role, string email, string password, string description, string medicalCares, string avatar, string addressReference)
        {
            this.id = id;
            this.institution = institution;
            this.addressNumber = addressNumber;
            this.addressId = addressId;
            this.birthDate = birthDate;
            this.sex = sex;
            this.accessLevel = accessLevel;
            this.name = name;
            this.cpf = cpf;
            this.rg = rg;
            this.role = role;
            this.email = email;
            this.password = password;
            this.description = description;
            this.medicalCares = medicalCares;
            this.avatar = avatar;
            this.addressReference = addressReference;
        }

        ~User()
        {
            Console.WriteLine("User destructor was called. Open fire!");
        }
    }
}
