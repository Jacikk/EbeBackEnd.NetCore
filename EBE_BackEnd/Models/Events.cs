using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Events
    {
        
        private int id, addressNumber,  street_Id;
        private string eventName, description, avatar, addressReference;
        private DateTime starting, ending;
        public Events() { }
        public Events(int id, int addressNumber, int street_Id, string eventName, string description, string avatar, string addressReference, DateTime starting, DateTime ending)
        {
            this.id = id;
            this.addressNumber = addressNumber;
            this.street_Id = street_Id;
            this.eventName = eventName;
            this.description = description;
            this.avatar = avatar;
            this.addressReference = addressReference;
            this.starting = starting;
            this.ending = ending;
        }

        public int Id { get => id; set => id = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public int Street_Id { get => street_Id; set => street_Id = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string Description { get => description; set => description = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }
        public DateTime Starting { get => starting; set => starting = value; }
        public DateTime Ending { get => ending; set => ending = value; }
    }
}
