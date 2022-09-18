//using BCrypt.Net;
//using ShopShoes.Data;
//using System.IdentityModel.Tokens.Jwt;
//using System.Reflection.Metadata;
//using System.Security.Claims;
//using WebShopShoes.Data.Account;
//using WebShopShoes.Dto.AccountDto;
//using WebShopShoes.IService.IAccount;
//using WebShopShoes.Model.Account;

//namespace WebShopShoes.Service.Account
//{
//    public class AccountRepository : IAccount
//    {
//        private readonly ShopDbContext _shopDbContext;

//        public AccountRepository (ShopDbContext shopDbContext)
//        {
//            _shopDbContext = shopDbContext;
//        }
//        LoginDto loginDto = new LoginDto();

//        public TokenModel Login(LoginDto login)
//        {
//            string passwordHash = _shopDbContext.accounts.FirstOrDefault(p => p.Username == login.UserName).Password;
//            var passwords = BCrypt.Net.BCrypt.Verify(login.Password, passwordHash);
//            loginDto.Password = passwordHash;
//            loginDto.UserName = login.UserName;
//            var token = Create(loginDto);



//        }

//        private TokenModel Create(LoginDto loginDto)
//        {
//            var user = _shopDbContext.accounts.FirstOrDefault(p => p.Username == loginDto.UserName);
//            List<Claim> claims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Name,loginDto.UserName),
//                new Claim(ClaimTypes.MobilePhone,user.Phone),
//                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
//                new Claim(ClaimTypes.StreetAddress, user.Address),
//                new Claim("Id", user.Id.ToString()),
//                new Claim(ClaimTypes.Role, user.isAdmin.ToString())
//            };

//        }

//        public ApiResponse Register(AccountDto accountDto)
//        {
//            var password = BCrypt.Net.BCrypt.HashPassword(accountDto.Password, Constant.Constant.PasswordSalt);
//            var dataAccount = new AccountData()
//            {
//                Address = accountDto.Address,
//                Password = password,
//                Phone = accountDto.Phone,
//                Username = accountDto.Username,
//                isAdmin = accountDto.isAdmin
//            };
//            _shopDbContext.Add(dataAccount);
//            _shopDbContext.SaveChanges();
//            return new ApiResponse
//            {
//                Success = true,
//                Message = "Sign Up Success"
//            };


//        }
//    }
//}
