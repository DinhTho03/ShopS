using BCrypt.Net;
using ShopShoes.Data;
using System.Reflection.Metadata;
using WebShopShoes.Data.Account;
using WebShopShoes.Dto.AccountDto;
using WebShopShoes.IService.IAccount;
using WebShopShoes.Model.Account;

namespace WebShopShoes.Service.Account
{
    public class AccountRepository : IAccount
    {
        private readonly ShopDbContext _shopDbContext;

        public AccountRepository (ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
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
