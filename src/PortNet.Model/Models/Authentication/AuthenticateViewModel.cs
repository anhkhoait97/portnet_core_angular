using PortNet.Model.Entities.INFPort;

namespace PortNet.Model.Models.Authentication
{
    public class AuthenticateViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        public AuthenticateViewModel(Users user, string token)
        {
            Id = user.Id;
            Username = user.UserName;
            Token = token;
        }
    }
}