using AutoMapper;
using Gta.Application.ViewModel;
using Gta.Domain.Entity;
using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup() {

            #region ViewModelToDomain
            CreateMap<UserViewModel, User>();
            CreateMap<MainViewModel, User>();
            CreateMap<ParcelViewModel, Parcel>();
            CreateMap<MainViewModel, Parcel>();
            #endregion

            #region DomainToViewModel
            CreateMap<User, UserViewModel>();
            CreateMap<User, MainViewModel>();
            CreateMap<Parcel, ParcelViewModel>();
            CreateMap<Parcel, MainViewModel>();
            #endregion

            #region MainViewModelTOUserViewModel
            CreateMap<MainViewModel, User>();
            CreateMap<MainViewModel, Parcel>();
            #endregion
            CreateMap<ParcelViewModel, MainViewModel>();
            CreateMap<MainViewModel, ParcelViewModel>();

        }
    }
}
