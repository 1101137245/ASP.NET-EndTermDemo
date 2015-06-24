using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    public class Ticket
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        //數量

        public string Date { get; set; }

        public string Time { get; set; }

        public string Aboard { get; set; }

        public string Getoff { get; set; }

        public string Number { get; set; }

        public string Phone { get; set; }

        public string Price { get; set; }

        public override string ToString()
        {
            return "Ticket: Id = " + Id + ", Name = " + Name + ".";
        }
    }
}
