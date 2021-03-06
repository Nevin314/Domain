﻿using CoreAPI2.Services.Model;
using System.Threading.Tasks;

namespace CoreAPI2.Services.Contracts
{
    public interface IUserService
    {
        Task<User> CreateAsync(User user);

        Task<bool> UpdateAsync(User user);

        Task<bool> DeleteAsync(string id);

        Task<User> GetAsync(string id);
    }
}
