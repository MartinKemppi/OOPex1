﻿using System;
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

    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }

        public void MessagePopularity(/*string content, string author, DateTime time*/)
        {
            int paljusõnumi = Convert.ToInt32(Console.ReadLine()); //N message - peab teha universaalne arv täitmiseks
            for (int i = 0; i < paljusõnumi; i++)
            {
                Console.WriteLine("Sisesta sõnum: ");
                string _content = Console.ReadLine();
                Console.WriteLine("Sisesta autor: ");
                string _author = Console.ReadLine();
                Console.WriteLine("Palju aega läbis sõnumit? paev, tund või minutt");
                string _vastus = Console.ReadLine();
                int _time = Convert.ToInt32(Console.ReadLine());

                    if (_time > 0)
                    {
                        _time *= -1;
                    }
                        if (_vastus == "paev")
                        {
                            Message m1 = new Message(_content, _author, DateTime.Now.AddDays(_time));
                            Console.WriteLine(m1.Content);
                            Console.WriteLine(m1.Time);
                            m1.AddLike();
                            Console.WriteLine(m1.GetPopularity());
                        }
                        else if (_vastus == "tund")
                        {
                            Message m1 = new Message(_content, _author, DateTime.Now.AddHours(_time));
                            Console.WriteLine(m1.Content);
                            Console.WriteLine(m1.Time);
                            m1.AddLike();
                            Console.WriteLine(m1.GetPopularity());
                        }
                        else if (_vastus == "minutt")
                        {
                            Message m1 = new Message(_content, _author, DateTime.Now.AddMinutes(_time));
                            Console.WriteLine(m1.Content);
                            Console.WriteLine(m1.Time);
                            m1.AddLike();
                            Console.WriteLine(m1.GetPopularity());
                        }
                        else
                        {
                            Console.WriteLine("Kijuta õige aja tüüp: paev, tund või minutt");
                            Console.ReadLine();
                        }
            }
        }

        public string Compare(double m1, double m2)
        {
            string result = "";
            if(m1 > m2) 
            {
                result = "m1 sõnum on populaarsem kui m2";
            }
            if(m1 < m2) 
            {
                result = "m2 sõnum on populaarsem kui m1";
            }
            return result;
        }

        public string GetPopularityInfo(List<Message>messages)
        {
            string result = "";
            double popularity = 0;
            for (int i= 0; i < messages.Count; i++) 
            {
                if (messages[i].GetPopularity()>popularity)
                {
                    result = messages[i].Content + " on kõige populaarsem sõnum, seda kirjutas " + messages[i].Author;
                }
            }

            return result;

        }
    }
}
