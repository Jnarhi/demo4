using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Viljo";
            person.LastName = "Viljanen";
            person.Age = 75;
            person.Address = "Katukatu 47";
            person.PhoneNumber = "04012341235";
            Console.WriteLine(person.ToString());


            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Tietie 23";
            teacher.Age = 45;
            teacher.PhoneNumber = "044333124652";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Meikäläinen", "K1111");
            student.Address = "Kujakuja 33";
            student.Age = 25;
            student.PhoneNumber = "0502221335";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
