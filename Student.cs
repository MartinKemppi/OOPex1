using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPex1
{

    public class Student
    {
        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 18) status = "alaealine";
                else status = "täiskavanud";
            }
        }

        public string Status
        {
            get { return status; }
        }

        public string GetCity()
        {
            return _city;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
            Console.WriteLine(Status);
            Console.WriteLine(Date());
            
        }

        public int Date()
        {
            int currentDateTime = DateTime.Now.Year;
            int BornYear = currentDateTime - age;
            return BornYear;
            

        }
    }
}
