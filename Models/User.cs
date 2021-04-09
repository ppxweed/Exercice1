using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string AccessLevel { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}