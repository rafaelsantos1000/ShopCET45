﻿using Microsoft.AspNetCore.Identity;
using ShopCET45.Web.Data.Entities;
using ShopCET45.Web.Models;
using System.Threading.Tasks;

namespace ShopCET45.Web.Helpers
{
    public interface IUserHelper
    {
        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<User> GetUserByEmailAsync(string email);


        Task<SignInResult> LoginAsync(LoginViewModel model);


        Task LogoutAsync();


        Task<IdentityResult> UpdateUserAsync(User user);


        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
    }
}
