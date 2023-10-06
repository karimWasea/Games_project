using Microsoft.AspNetCore.Identity;

namespace Games_project.Models
{
    public class Applicaionuser :IdentityUser
    {
        public DateTime? BirthDate { get; set; }
        public string ProfileImage { get; set; }
        public Gender Gender { get; set; }
        public string Adress { get; set; }
    }


   public enum Gender
    {
    }
}