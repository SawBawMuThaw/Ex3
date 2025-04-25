namespace SchoolCoreAppRazor.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int Departments { get; set; }    

        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
