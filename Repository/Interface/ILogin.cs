﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntityApi.Repository.Interface
{
    public interface ILogin
    {
        public int GetLogin(Model.Entity.Registration RegistrationModel, int Id, string UserName);
    }
}
