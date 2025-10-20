using System;
using System.Collections.Generic;

namespace StudentCourseApp
{
    class Student
    {
        public int Id;
        public string Name;
        public string City;
        public string Area;
        public DateTime DOB;
        public string Gender;
        public string Department;
        public string Course;
    }

    class StudentManager
    {
        public List<Student> students = new List<Student>();

        public string AddStudent(Student s)
        {
            if (students.Count >= 10)
                return "Maximum 10 students allowed!";

            if (s.Id <= 0)
                return "Invalid ID!";
            if (string.IsNullOrEmpty(s.Name))
                return "Name cannot be empty!";
            if (string.IsNullOrEmpty(s.City))
                return "City must be selected!";
            if (s.DOB > DateTime.Now)
                return "Date of Birth cannot be in future!";
            if (string.IsNullOrEmpty(s.Gender))
                return "Select Gender!";

            students.Add(s);
            return "Student added successfully!";
        }

        public string UpdateStudent(Student s)
        {
            Student found = students.Find(x => x.Id == s.Id);
            if (found == null)
                return "Student not found!";

            found.Name = s.Name;
            found.City = s.City;
            found.Area = s.Area;
            found.DOB = s.DOB;
            found.Gender = s.Gender;
            found.Department = s.Department;
            found.Course = s.Course;

            return "Student updated successfully!";
        }

        public string DeleteStudent(int id)
        {
            Student found = students.Find(x => x.Id == id);
            if (found == null)
                return "Student not found!";
            students.Remove(found);
            return "Student deleted successfully!";
        }

        public Student GetStudent(int id)
        {
            return students.Find(x => x.Id == id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\n********* Student Course Management *********");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Get Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Student s = new Student();
                    Console.Write("Enter ID: ");
                    s.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Enter City: ");
                    s.City = Console.ReadLine();
                    Console.Write("Enter Area: ");
                    s.Area = Console.ReadLine();
                    Console.Write("Enter DOB (yyyy-mm-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out s.DOB);
                    Console.Write("Enter Gender (Male/Female): ");
                    s.Gender = Console.ReadLine();
                    Console.Write("Enter Department (CS/Math/Others): ");
                    s.Department = Console.ReadLine();
                    Console.Write("Enter Course: ");
                    s.Course = Console.ReadLine();

                    Console.WriteLine(manager.AddStudent(s));
                }
                else if (choice == "2")
                {
                    Console.Write("Enter ID to Update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Student s = manager.GetStudent(id);
                    if (s == null)
                    {
                        Console.WriteLine("Student not found!");
                        continue;
                    }

                    Console.Write("Enter New Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Enter New City: ");
                    s.City = Console.ReadLine();
                    Console.Write("Enter New Area: ");
                    s.Area = Console.ReadLine();
                    Console.Write("Enter New DOB (yyyy-mm-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out s.DOB);
                    Console.Write("Enter Gender (Male/Female): ");
                    s.Gender = Console.ReadLine();
                    Console.Write("Enter Department: ");
                    s.Department = Console.ReadLine();
                    Console.Write("Enter Course: ");
                    s.Course = Console.ReadLine();

                    Console.WriteLine(manager.UpdateStudent(s));
                }
                else if (choice == "3")
                {
                    Console.Write("Enter ID to Delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(manager.DeleteStudent(id));
                }
                else if (choice == "4")
                {
                    Console.Write("Enter ID to Search: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Student s = manager.GetStudent(id);
                    if (s == null)
                        Console.WriteLine("Student not found!");
                    else
                    {
                        Console.WriteLine($"ID: {s.Id}");
                        Console.WriteLine($"Name: {s.Name}");
                        Console.WriteLine($"City: {s.City}");
                        Console.WriteLine($"Area: {s.Area}");
                        Console.WriteLine($"DOB: {s.DOB.ToShortDateString()}");
                        Console.WriteLine($"Gender: {s.Gender}");
                        Console.WriteLine($"Department: {s.Department}");
                        Console.WriteLine($"Course: {s.Course}");
                    }
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Exiting");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }
    }
}
