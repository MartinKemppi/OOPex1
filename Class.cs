using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPex1
{
    
        public class StudentMain
        {
            public static void Main()
            {
                Student student = new Student("John", 17, "London");



                //Console.WriteLine(student.Name);
                //Console.WriteLine(student.Age);
                //Console.WriteLine(student.GetCity());

                student.ShowInfo();
            }
        }
         
}
