using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFirstClass
{
    public class Person
    {
        public string Name {  get; set; }

        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public void DisplayInfo () 
        {
            Console.WriteLine($"Ad {Name}, Soyadı {Surname}, Doğum Tarihi {BirthDate.ToShortDateString()}");

        }
    }
}
