using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace ClassCodeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People peopleList = new People();

            Student student1;
            Teacher teacher1;
            Student student2;
            Teacher teacher2;

            student1 = new Student();
            student1.name = "John Smith";
            student1.age = 21;
            student1.gpa = 4;
            student1.LicenseId = 123;
            student1.email = "j@s.com";

            student2 = new Student();
            student2.name = "Mary Johnson";
            student2.age = 19;
            student2.gpa = 3.4;
            student2.LicenseId = 456;
            student2.email = "m@j.com";

            teacher1 = new Teacher();
            teacher1.name = "Joe Howard";
            teacher1.age = 45;
            teacher1.specialty = "Math";
            teacher1.LicenseId = 789;
            teacher1.email = "j@h.com";

            teacher2 = new Teacher();
            teacher2.name = "Scott Clinton";
            teacher2.age = 51;
            teacher2.specialty = "Psychology";
            teacher2.LicenseId = 987;
            teacher2.email = "s@c.com";

            peopleList[student1.email] = student1;
            peopleList[student2.email] = student2;
            peopleList[teacher1.email] = teacher1;
            peopleList[teacher2.email] = teacher2;

            int[] iArray = new int[5];
            foreach(int i in iArray)
            {

            }

            foreach( KeyValuePair<string,Person> kvp in peopleList.sortedList )
            {
                if( kvp.Value is Student )
                {
                    Student student = (Student)kvp.Value;
                    Console.WriteLine($"Name: {student.name} Age: {student.age} Email: {student.email} GPA: {student.gpa}");
                }
                else
                {
                    Teacher teacher = (Teacher)kvp.Value;
                    Console.WriteLine($"Name: {teacher.name} Age: {teacher.age} Email: {teacher.email} Specialty: {teacher.specialty}");
                }
            }

            // compare students by their gpa
            if( student1 > student2)
            {

            }

            // compare students by age
            if ((Person)student1 > (Person)student2)
            {

            }


            List<Person> lPeople = new List<Person>();

            lPeople.Add(student1);
            lPeople.Add(student2);
            lPeople.Add(teacher1);
            lPeople.Add(teacher2);

            // sorts the list in place (the contents of lPeople has changed)
            // uses the IComparable interface in the Person class to implement CompareTo() which determines how to sort the Person class objects
            lPeople.Sort();

            // OrderBy does NOT sort the list in place, but returns a copy of the list instead
            // (the contents of lPeople has NOT changed)
            // and it takes a delegate method to return which field to sort by
            // 5 ways to write the delegate method
            lPeople = lPeople.OrderBy(delegate (Person p) { return p.name; }).ToList();
            lPeople = lPeople.OrderBy((Person p) => { return p.name; }).ToList();
            lPeople = lPeople.OrderBy((p) => { return p.name; }).ToList();
            lPeople = lPeople.OrderBy((p) => p.name).ToList();
            lPeople = lPeople.OrderBy(p => p.name).ToList();

            // OrderBy is like GetRange() which also returns a copy of the list
            List<Person> newList = lPeople.GetRange(0, lPeople.Count);

        }
    }
}
