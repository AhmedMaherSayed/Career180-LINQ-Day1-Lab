namespace Day1_Lab
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Subject> subjects { get; set; } = new List<Subject>();
    }
}