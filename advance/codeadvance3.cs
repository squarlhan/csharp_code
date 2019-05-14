using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace SortStudents
{
    class SortStudents
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens[0];
                var lastName = tokens[1];
                students.Add(new Student(firstName, lastName));

                input = Console.ReadLine();
            }

            students.OrderBy(s => s.LastName)
                .ThenByDescending(s => s.FistName)
                .ToList()
                .ForEach(st => Console.WriteLine($"{st.FistName} {st.LastName}"));
        }

        class Student
        {
            public Student(string firstName, string lastName)
            {
                this.FistName = firstName;
                this.LastName = lastName;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace FilterStudentsByEmailDomain
{
    class FilterStudentsByEmailDomain
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens[0];
                var lastName = tokens[1];
                var email = tokens[2];
                students.Add(new Student(firstName, lastName, email));

                input = Console.ReadLine();
            }

            students.Where(s => s.Email.ToLower().EndsWith(@"@gmail.com"))
                .ToList()
                .ForEach(st => Console.WriteLine($"{st.FistName} {st.LastName}"));
        }

        class Student
        {
            public Student(string firstName, string lastName, string email)
            {
                this.FistName = firstName;
                this.LastName = lastName;
                this.Email = email;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }
    }
}


//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace ExcellentStudents
{
    class ExcellentStudents
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens[0];
                var lastName = tokens[1];
                var marks = new List<int>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    var mark = int.Parse(tokens[i]);
                    marks.Add(mark);
                }
                students.Add(new Student(firstName, lastName, marks));

                input = Console.ReadLine();
            }

            students.Where(s => s.Marks.Any(m => m == 6))
                .ToList()
                .ForEach(st => Console.WriteLine($"{st.FistName} {st.LastName}"));
        }

        class Student
        {
            public Student(string firstName, string lastName, List<int> marks)
            {
                this.FistName = firstName;
                this.LastName = lastName;
                this.Marks = marks;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
            public ICollection<int> Marks { get; set; }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace WeakStudents
{
    class WeakStudents
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens[0];
                var lastName = tokens[1];
                var marks = new List<int>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    var mark = int.Parse(tokens[i]);
                    marks.Add(mark);
                }
                students.Add(new Student(firstName, lastName, marks));

                input = Console.ReadLine();
            }

            students.Where(s => s.Marks.Where(m => m <= 3).Count() >= 2)
                .ToList()
                .ForEach(st => Console.WriteLine($"{st.FistName} {st.LastName}"));
        }

        class Student
        {
            public Student(string firstName, string lastName, List<int> marks)
            {
                this.FistName = firstName;
                this.LastName = lastName;
                this.Marks = marks;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
            public ICollection<int> Marks { get; set; }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace GroupByGroup
{
    class GroupByGroup
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens[0];
                var lastName = tokens[1];
                int groupId = int.Parse(tokens[2]);
                students.Add(new Student(firstName, lastName, groupId));

                input = Console.ReadLine();
            }

            var res = students
                .GroupBy(g => g.GroupId, g =>
                    new { FirstName = g.FistName, LastName = g.LastName },
                    (groupID, studs) =>
                    new { id = groupID, sts = studs.ToList() })
                .ToList();

            foreach (var group in res.OrderBy(x => x.id))
            {
                Console.WriteLine($"{group.id} - {string.Join(", ", group.sts.Select(st => st.FirstName + " " + st.LastName))}");
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, int groupId)
            {
                this.FistName = firstName;
                this.LastName = lastName;
                this.GroupId = groupId;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
            public int GroupId { get; set; }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<StudentSpeciality> studentSpecialities = new List<StudentSpeciality>();
            List<Student> students = new List<Student>();

            while (input != "Students:")
            {
                var tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var speciality = tokens[0] + " " + tokens[1];
                var facNum = int.Parse(tokens[2]);

                studentSpecialities.Add(new StudentSpeciality(speciality, facNum));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int facNum = int.Parse(tokens[0].Trim());
                var firstName = tokens[1];
                var lastName = tokens[2];
                students.Add(new Student(firstName, lastName, facNum));

                input = Console.ReadLine();
            }

            var results = students.Join(studentSpecialities, s => s.FacNum, x => x.FacNum, (pk, fk) => new { FirstName = pk.FistName, LastName = pk.LastName, FacNum = pk.FacNum, Speciality = fk.SpecialtyName }).ToList();

            foreach (var student in results.OrderBy(st => st.FirstName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.FacNum} {student.Speciality}");
            }
        }

        class StudentSpeciality
        {
            public StudentSpeciality(string firstName, int facNUm)
            {
                this.SpecialtyName = firstName;
                this.FacNum = facNUm;
            }

            public string SpecialtyName { get; set; }
            public int FacNum { get; set; }
        }

        class Student
        {
            public Student(string firstName, string lastName, int facNUm)
            {
                this.FistName = firstName;
                this.LastName = lastName;
                this.FacNum = facNUm;
            }

            public string FistName { get; set; }
            public string LastName { get; set; }
            public int FacNum { get; set; }
        }
    }
}