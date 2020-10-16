using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex1 = new Student(-12, "Sergej", "Vengura");
            var ex2 = new Student();

            


            Console.ReadLine();

        }


        public class Student
        {
            public int Id { get; set; } 
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Lastname { get; set; }
            public DateTime Birthday { get; set; }
            public string Address { get; set; }
            public long PhoneNumber { get; set; }
            public string Faculty { get; set; }
            public int CourseNumber { get; set; }
            public int GroupNumber { get; set; }
            public int Age { get; set; }

            static Student() { Console.WriteLine("Создается при первом создании обьекта"); }
            public Student() { }
            public Student(int _id, string _name, string _surname)
            {
                if(_id < 0)
                {
                    throw new ArgumentException(nameof(_id));
                    
                }
                
                Id = _id;
                                Name = _name;
                Surname = _surname;
            }
            
            public Student(int _id, string _name, string _surname, string _lastname, DateTime _birthday, string _address, long _phoneNumber, string _faculty, int _courseNumber, int _groupNumber)
            {
                if (_id < 0) throw new ArgumentException(nameof(_id));
                if (string.IsNullOrWhiteSpace(_name)) throw new ArgumentNullException(nameof(_name));
                if (string.IsNullOrWhiteSpace(_surname)) throw new ArgumentNullException(nameof(_surname));
                if (string.IsNullOrWhiteSpace(_lastname)) throw new ArgumentNullException(nameof(_lastname));
                if (_birthday>DateTime.Today) throw new ArgumentException(nameof(_birthday));
                if (string.IsNullOrWhiteSpace(_address)) throw new ArgumentNullException(nameof(_address));
                if (_phoneNumber < 0 ) throw new ArgumentException(nameof(_phoneNumber));
                if (string.IsNullOrWhiteSpace(_faculty)) throw new ArgumentException(nameof(_faculty));
                if (_courseNumber < 0 || _courseNumber>5) throw new ArgumentException(nameof(_courseNumber));
                if (_groupNumber < 0 || _groupNumber>10) throw new ArgumentException(nameof(_groupNumber));

                Id = _id; 
                Name = _name; 
                Surname = _surname;
                Lastname = _lastname; 
                Birthday = _birthday;
                Address = _address;
                PhoneNumber = _phoneNumber;
                Faculty = _faculty;
                CourseNumber = _courseNumber;
                GroupNumber = _groupNumber;
                Age = Age_calc(_birthday);

            }
            private int Age_calc(DateTime birthday)
            {
                DateTime today = DateTime.Today;
                
                return today.Year - birthday.Year;
            }
        }
    }
}
