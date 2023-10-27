using System.ComponentModel.DataAnnotations;

namespace Stock.Data.Models
{
    public class CredentialsDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
