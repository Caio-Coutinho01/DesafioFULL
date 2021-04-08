using Gta.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Application.interfaces
{
    public interface IUserService
    {
        List<MainViewModel> GetAll();
        bool Post(MainViewModel[] mainViewModel);
        List<ParcelViewModel> GetById(string id);
        bool Put(UserViewModel userViewModel);
        bool Delete(string id);
    }
}
