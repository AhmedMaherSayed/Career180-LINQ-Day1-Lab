namespace Day1_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            #region Query1
            //var query1 = numbers.Distinct()
            //        .OrderBy(x => x)
            //        .ToList();

            //foreach (var number in query1)
            //    Console.WriteLine(number);  
            #endregion

            #region Query2
            //foreach ( var item in query1 )
            //{
            //    Console.WriteLine($"(Number = {item}, Multiply = {Math.Pow(item,2)})");
            //}
            #endregion
            #endregion

            #region Q2
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            #region Query1
            //var query1 = names.Where(name => name.Length == 3);

            //foreach (var name in query1)
            //    Console.WriteLine(name);
            #endregion

            #region Query2
            //var query2 = names.Where(name => name.Contains('a') || name.Contains("A"))
            //    .OrderBy(name => name.Length);

            //foreach (var name in query2)
            //    Console.WriteLine(name);
            #endregion

            #region Query3
            //var query3 = names.Take(2);

            //foreach (var name in query3)
            //    Console.WriteLine(name);
            #endregion

            #endregion

            #region Q3
            List<Student> students = new List<Student>()
            { new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                subjects=new List<Subject>{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},             
                new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                subjects=new List<Subject>{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new List<Subject>{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},       
                new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                 subjects=new List<Subject>{  new Subject (){ Code=33,Name="UML"}}}
            };

            #region query1
            //var query1 = students.Select(student => 
            //                            new { FullName = $"{student.FirstName} {student.LastName}",
            //                            NoOfSubjects = student.subjects.Count });

            //foreach (var student in query1)
            //    Console.WriteLine($"(FullName = {student.FullName}, NoOfSubjects = {student.NoOfSubjects})");
            #endregion

            #region Query2
            var query2 = students.OrderByDescending(student => student.FirstName)
                .ThenBy(student => student.LastName)
                .Select(student => new {FullName = $"{student.FirstName} {student.LastName}" });

            foreach (var name in query2)
                Console.WriteLine(name);
            #endregion

            #endregion
        }
    }
}
