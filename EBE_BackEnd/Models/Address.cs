using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Address
    {
        private int id;

        private string
            cep,
            city,
            street,
            country,
            state,
            district;
        public Address()
        {

        }
        public Address(
            int id,
            string cep,
            string city,
            string country,
            string street,
            string state,
            string district)
        {
            this.id = id;
            this.cep = cep;
            this.city = city;
            this.country = country;
            this.street = street;
            this.state = state;
            this.district = district;
        }

        public string Cep { get => cep; set => cep = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string State { get => state; set => state = value; }
        public string District { get => district; set => district = value; }
        public string Country { get => country; set => country = value; }
        public int Id { get => id; set => id = value; }


        ~Address()
        {
            Console.WriteLine("Address destructor was called. Open fire!");
        }
    }
}
