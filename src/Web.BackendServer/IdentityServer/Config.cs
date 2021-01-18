using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Web.BackendServer.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope("api.portnet", "Port.Net API")
        };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "swagger",
                    ClientName = "Swagger Client",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,
                    AccessTokenLifetime = 60,
                    RedirectUris =           { "https://localhost:5000/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { "https://localhost:5000/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { "https://localhost:5000" },
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api.portnet"
                    }
                },
                new Client
                {
                    ClientName = "Angular Admin",
                    ClientId = "angular_admin",
                    AccessTokenType = AccessTokenType.Reference,
                    RequireConsent = false,
                    AccessTokenLifetime = 60,
                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:4200",
                        "http://localhost:4200/auth-callback",
                        "http://localhost:4200/silent-renew.html"
                    },
                    PostLogoutRedirectUris = new List<string> { "http://localhost:4200" },
                    AllowedCorsOrigins = new List<string> { "http://localhost:4200" },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api.portnet"
                    }
                },
                new Client
                {
                    ClientId = "client",
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    // scopes that client has access to
                    AllowedScopes = { "api.portnet" }
                }
            };
    }
}