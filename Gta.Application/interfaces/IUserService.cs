using Gta.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Application.interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();

    }
}
