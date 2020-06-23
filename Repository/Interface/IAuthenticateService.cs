using CoreEntityApi.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntityApi.Repository.Interface
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
