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

                Console.WriteLine();

                Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
                Console.WriteLine(m1.Content);
                Console.WriteLine(m1.Time);
                m1.AddLike();
                Console.WriteLine(m1.GetPopularity());
                               
                Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
                Console.WriteLine(m2.Content);
                m2.AddLike();
                Console.WriteLine(m2.GetPopularity());
                Console.Write("m1.GetPopularity() < m2.GetPopularity(): ");
                Console.WriteLine(m1.GetPopularity() < m2.GetPopularity());




                //m1.MessagePopularity();
                
                for (int i = 0; i < 1000; i++) { m2.AddLike(); }

                //Console.WriteLine(m2.GetPopularity());
                //Console.WriteLine(m1.GetPopularityInfo(m1.GetPopularity(), m2.GetPopularity()));
                Message m3 = new Message("Tere","Mari",DateTime.Now.AddDays(-1));
                Message m4 = new Message("Guten Tag", "Hans", DateTime.Now.AddDays(-5));
                Message m5 = new Message("Hei", "Marika", DateTime.Now.AddDays(-10));
                List<Message> list = new List<Message>();
                list.Add(m1);
                list.Add(m2);
                list.Add(m3);
                list.Add(m4);
                list.Add(m5);

                Console.WriteLine();

            {
                List<Message> messages = Message.GenerateRandomMessages();

                foreach (var message in messages)
                {
                    Console.WriteLine("Generated message:");
                    Console.WriteLine($"Content: {message.Content}");
                    Console.WriteLine($"Author: {message.Author}");
                    Console.WriteLine($"Time: {message.Time}");
                    Console.WriteLine($"Popularity: {message.GetPopularity()}");
                    Console.WriteLine();
                }

                // Find the most popular message
                Message mostPopularMessage = Message.FindMostPopularMessage(messages);

                if (mostPopularMessage != null)
                {
                    Console.WriteLine("Most Popular Message:");
                    Console.WriteLine($"Content: {mostPopularMessage.Content}");
                    Console.WriteLine($"Author: {mostPopularMessage.Author}");
                    Console.WriteLine($"Time: {mostPopularMessage.Time}");
                    Console.WriteLine($"Popularity: {mostPopularMessage.GetPopularity()}");
                }
                else
                {
                    Console.WriteLine("No messages to compare.");
                }
            }


        }
    }
         
}
