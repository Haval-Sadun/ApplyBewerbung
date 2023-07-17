using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ApplySys.Identity
{
    public static class KeycloakAuthentication
    {
        public static void AddKeycloakAuthentication(this IServiceCollection services,
                                                     string keycloakAuthority,
                                                     string keycloakAudience,
                                                     string keycloakIssuer,
                                                     string keycloakAudienceSecret)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.Authority = "http://localhost:8080/auath/realms/apply-sys";
                    options.Audience = "account";
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = false,
                        ValidIssuer = "http://localhost:8080/auth/realms/apply-sys",
                        ValidAudience = "account",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keycloakAudienceSecret))
                    };
                });
        }
    }
}
