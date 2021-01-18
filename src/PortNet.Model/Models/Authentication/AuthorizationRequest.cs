using System.ComponentModel.DataAnnotations;

namespace PortNet.Model.Models.Authentication
{
    public class AuthorizationRequest
    {
        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        [Required]
        public string Scope { get; set; }
    }
}