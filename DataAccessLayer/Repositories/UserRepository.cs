﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Users;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public Administrators Retrieve(string name)
        {
            List<Administrators> users = GetUsers();
            foreach (Administrators currentUser in users)
            {
                if (currentUser.Name == name) {
                    return currentUser;
                }
            }
            throw new TypeAccessException("No such product!");
        }

        public List<Administrators> GetUsers()
        {
           return new List<Administrators> { new Administrators("Nataly"), new Administrators("Leo") };
        }
    }
}