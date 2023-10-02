using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkenMetRijen
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {

        }

        public override string ToString()
        {

            return "Id: " + Id + "; Naam: " + Name + ";";
        }
    }
}
