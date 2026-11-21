namespace StudentPortal.Web.Models.Entites
{
    public class Student
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}
