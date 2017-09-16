namespace BloodManagmentSystem.Models
{
    public class Donor
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Donor(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}