﻿using IdentityServer4.Models;
using System.Collections.Generic;

namespace Auth
{
    public class Clients
    {
        public IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client 
                {
                    ClientId = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> 
                    {
                       new Secret("superSecretPassword".Sha256())
                    },
                    AllowedScopes = new List<string> {"customAPI.read"}
                }
            };
        }
    }
}
