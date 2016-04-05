using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace Web.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(IUser user)
        {
            User = user;
        }

        public IUser User { get; }
    }
}
