using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Models
{
    public class Palestrantes
    {
        int id, palestrante, subevent_id;

        public Palestrantes() { }
        public Palestrantes(int id, int palestrante, int subevent_id)
        {
            this.id = id;
            this.palestrante = palestrante;
            this.subevent_id = subevent_id;
        }

        public int Id { get => id; set => id = value; }
        public int Palestrante { get => palestrante; set => palestrante = value; }
        public int Subevent_id { get => subevent_id; set => subevent_id = value; }
    }
}
