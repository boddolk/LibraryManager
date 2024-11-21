﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMeneger.Data.UserRepository
{
    public abstract class IUserRepository
    {
        
               
        public IUserRepository() { }
        public abstract bool DoesSuchUserExist(string loginToCheck);
        public abstract bool IsGivenUserAdmin(string loginToCheck);
        public abstract bool IsPasswordCorrect(string loginToCheck, string Password);
    }
}