using BCrypt.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShopShoes.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using WebShopShoes.Data.Account;
using WebShopShoes.Dto.AccountDto;
using WebShopShoes.IService.IAccount;
using WebShopShoes.Model.Account;

namespace WebShopShoes.Service.Account
{
    public class AccountRepository : IAccount
    {
        private readonly IConfiguration _configuration;
        private readonly ShopDbContext _shopDbContext;

        public AccountRepository(IConfiguration configuration,ShopDbContext shopDbContext)
        {
            _configuration = configuration;
            _shopDbContext = shopDbContext;
        }
        LoginDto loginDto = new LoginDto();

        public TokenModel Login(LoginDto login)
        {
            string passwordHash = _shopDbContext.accounts.FirstOrDefault(p => p.Username == login.UserName).Password;
            var passwords = BCrypt.Net.BCrypt.Verify(login.Password, passwordHash);
            loginDto.Password = passwordHash;
            loginDto.UserName = login.UserName;
            var token = Create(loginDto);
            if (passwords)
            {
                return new TokenModel
                {
                    AccessToken = token.AccessToken
                };
            }
            return null;


        }

        private TokenModel Create(LoginDto loginDto)
        {
            var user = _shopDbContext.accounts.FirstOrDefault(p => p.Username == loginDto.UserName);
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,loginDto.UserName),
                new Claim(ClaimTypes.MobilePhone,user.Phone),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.StreetAddress, user.Address),
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.isAdmin.ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:SecretKey").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return new TokenModel
            {
                AccessToken = jwt,
            };

        }

        public ApiResponse Register(AccountDto accountDto)
        {
            var password = BCrypt.Net.BCrypt.HashPassword(accountDto.Password, Constant.Constant.PasswordSalt);
            var dataAccount = new AccountData()
            {
                Address = accountDto.Address,
                Password = password,
                Phone = accountDto.Phone,
                Username = accountDto.Username,
                isAdmin = accountDto.isAdmin
            };
            _shopDbContext.Add(dataAccount);
            _shopDbContext.SaveChanges();
            return new ApiResponse
            {
                Success = true,
                Message = "Sign Up Success"
            };


        }
    }
}
