﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DisserCore.Models.Base
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // издатель токена
        public const string AUDIENCE = "MyAuthClient"; // потребитель токена
        const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
        public const int LIFETIME = 30; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
        public string? access_token { get; set; }
        public string? role { get; set; }
        public string? username { get; set; }
        public int? Id { get; set; }
    }
}
