namespace WebApplication1.Models
{
    public class IndexViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
