﻿using RoleBasedAuthorization.Models;
using System.Collections.Generic;

namespace RoleBasedAuthorization.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
