using System.Security.Principal;

namespace tl2_tp6_2024_cristianlana12
{
    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;} = string.Empty;
        public string Password{get; set;} = string.Empty;
        public AccessLevel AccessLevel{get; set;}
    }

    public enum AccessLevel
    {
        Admin,
        Usuario
    }
}