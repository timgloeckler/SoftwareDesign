using System;
using System.Collections.Generic;

namespace Aufgabe5_UML
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Nothing is happening over here
        }
    }

    class Person
    {
        public string Name;
        public int Age;
    }

    class Participant : Person
    {
        public int Matrikelnummer;
        public List<Course> Courses;
    }

    class Dozent : Person
    {
        public string OfficeNr;
        public string ConsultingHours;
        public List<Course> Courses;

        public void GehalteneCourses()
        {
            Console.WriteLine("Ich unterrichte: ");
            foreach(var Course in Courses)
            {
                Console.WriteLine("- " + Course);
            }
        }
        public List<Participant> AllParticipants()
        {
            var participant = new List<Participant>();
            foreach(var Course in Courses)
            {
                participant.AddRange(Course.Participant);
            }
            return participant;
        }
    }

    class Course
    {
        public string Title;
        public string Date;
        public string RoomNr;
        public Dozent Dozent;
        public List<Participant> Participant;

        public string Infotext()
        {
            return "The Course '" + Title + "' of the Dozent/in " + Dozent.Name + " will take place on the " + Date + " in the Room " + RoomNr + ".";
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
