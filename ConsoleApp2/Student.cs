using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void showThongTin()
        {
            Console.WriteLine(""+Id+ " - "+ Name + " - " + Age + "");
        }
    }
}
