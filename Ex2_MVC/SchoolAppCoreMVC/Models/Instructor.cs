namespace SchoolAppCoreMVC.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly HireDate { get; set; }
    }
}
