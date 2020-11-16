using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EBE_BackEnd.Models
{

    public class User
    {

        private int id, institution;
        private int addressNumber, street_id;
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
            addressReference,
            telefone1,
            telefone2;

        public int Id { get => id; set => id = value; }
        public int Institution { get => institution; set => institution = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public int Street_Id { get => street_id; set => street_id = value; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        [Required]
        public bool Sex { get => sex; set => sex = value; }
        public string AccessLevel { get => accessLevel; set => accessLevel = value; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Only character are not allowed.")]
        public string Name { get => name; set => name = value; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Numbers.")]
        public string Cpf { get => cpf; set => cpf = value; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Numbers.")]
        public string Rg { get => rg; set => rg = value; }
        public string Role { get => role; set => role = value; }
        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        public string Description { get => description; set => description = value; }
        [Required]
        public string MedicalCares { get => medicalCares; set => medicalCares = value; }
        [Required]
        public string Avatar { get => avatar; set => avatar = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Numbers.")]
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Numbers.")]
        public string Telefone2 { get => telefone2; set => telefone2 = value; }

        public User()
        {
        }

        public User(int id, int institution, int addressNumber, int addressId, DateTime birthDate, bool sex, string accessLevel, string name, string cpf, string rg, string role, string email, string password, string description, string medicalCares, string avatar, string addressReference, string telefone1, string telefone2)
        {
            this.id = id;
            this.institution = institution;
            this.addressNumber = addressNumber;
            this.street_id = addressId;
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
            this.telefone1 = telefone1;
            this.telefone2 = telefone2;
        }

        ~User()
        {
            Console.WriteLine("User destructor was called. Open fire!");
        }
    }
}
