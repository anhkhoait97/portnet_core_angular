using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using PortNet.Data.Repositories;
using PortNet.Model.Models.Authentication;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.BackendServer.Controllers
{
    [ApiController]
    public class GetTokenController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public GetTokenController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Authenticate
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("/token-jwt")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userRepository.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        /// <summary>
        /// GetToken
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("/token-oauth2")]
        public async Task<IActionResult> GetToken(AuthorizationRequest model)
        {
            // discover endpoints from metadata
            var client = new HttpClient();
            DiscoveryDocumentResponse disco = await client.GetDiscoveryDocumentAsync("https://localhost:5000");
            // check host
            if (disco.IsError)
                return BadRequest(disco.Error);
            // request token
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = model.ClientId,
                ClientSecret = model.ClientSecret,
                Scope = model.Scope
            });
            // check token
            if (tokenResponse.IsError)
                return BadRequest(tokenResponse.Error);
            else
                return Ok(tokenResponse.AccessToken);
        }
    }
}