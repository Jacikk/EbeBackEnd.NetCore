using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class EventsImages
    {
        private int id,  events_id;
        private string imageAddres;

        public EventsImages () { }
        public EventsImages(int id, int events_id, string imageAddres)
        {
            this.id = id;
            Events_id = events_id;
            this.imageAddres = imageAddres;
        }

        public int Id { get => id; set => id = value; }
        public int Events_id { get => events_id; set => events_id = value; }
        public string ImageAddres { get => imageAddres; set => imageAddres = value; }
    }
}
