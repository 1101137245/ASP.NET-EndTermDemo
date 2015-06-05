using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    public class Course
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Aboard { get; set; }

        public string Getoff { get; set; }

        public string Number { get; set; }

        public string Site { get; set; }

        public string Price { get; set; }

        public override string ToString()
        {
            return "Course: Id = " + Id + ", Name = " + Name + ".";
        }
    }
}
