using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { };
            Student student = new Student()
            {
                Id = 1,
                Name = "ngoc",
                Age = 6
            };
            students.Add(student);
            Student student1 = new Student()
            {
                Id = 2,
                Name = "mai",
                Age = 9
            };
            students.Add(student1);
            Student student2 = new Student()
            {
                Id = 3,
                Name = "linh",
                Age = 9
            };
            students.Add(student2);
            Student student3 = new Student()
            {
                Id = 4,
                Name = "hien",
                Age = 16
            };
            students.Add(student3);
            Student student4 = new Student()
            {
                Id = 5,
                Name = "Anh",
                Age = 20
            };
            students.Add(student4);
            Console.WriteLine("Danh sach toan bo sinh vien:");
            foreach (var stud in students)
            {
                stud.showThongTin();
            }
            var s1 = students.Where(x => x.Age >= 15 && x.Age <= 18).ToList();
            Console.WriteLine("\nDanh sach sinh vien tu 15 tuoi tro len:");
            foreach (var s in s1)
            {
                s.showThongTin();
            }

            var s2 = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nSinh vien co ten bat dau bang chu A:");
                foreach (var s in s2)
                {
                    s.showThongTin();
                }
            int s3 = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi cua cac sinh vien: {s3}");
            var s4 = students.OrderByDescending(s => s.Age).FirstOrDefault();
                Console.WriteLine($"Sinh vien co tuoi lon nhat: ");
                Console.WriteLine($"ID: {s4.Id}, Name: {s4.Name}, Age: {s4.Age}");
            var s5 = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("Danh sach sinh vien tuoi tang dan:");
            foreach (var s in s5)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }

            Console.ReadLine();


        }
    }
}
