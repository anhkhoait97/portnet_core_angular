using System.ComponentModel.DataAnnotations;

namespace PortNet.Model.Models.Authentication
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}