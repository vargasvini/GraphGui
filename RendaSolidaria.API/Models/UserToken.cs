using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RendaSolidaria.API.Models
{
    public class UserToken
    {
        public UserToken(Login userInfo, IConfiguration configuration)
        {
            var claim = new[]
            {
                new Claim("email", userInfo.Email),
                new Claim("Idade", "21"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.Now.AddSeconds(20);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claim,
                expires: expiration,
                signingCredentials: credentials
            );

            Token = new JwtSecurityTokenHandler().WriteToken(token);
            Expiration = expiration;
        }

        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
