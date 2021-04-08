using AutoMapper;
using Gta.Application.interfaces;
using Gta.Application.ViewModel;
using Gta.Domain.Entity;
using Gta.Domain.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gta.Application.Services
{
    public class UserService : IUserService
    {
 

        private readonly IUserRepository userRepository;
        private readonly IParcelRepository parcelRepository;

        private readonly IMapper mapper;

      
        public UserService(IUserRepository userRepository, IParcelRepository parcelRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.parcelRepository = parcelRepository;
            this.mapper = mapper;
        }

        //public List<MainViewModel> GetAll()
        //{
        //    List<MainViewModel> _mainViewModel = new List<MainViewModel>();
        //    IEnumerable<User> _users = this.userRepository.GetAll();

        //    _mainViewModel = mapper.Map<List<MainViewModel>>(_users);

        //    return _mainViewModel;
        //}
        public List<MainViewModel> GetAll()
        {
            List<MainViewModel> _mainViewModel = new List<MainViewModel>();
            List<MainViewModel> _resultViewModel = new List<MainViewModel>();
            List<ParcelViewModel> _parcelViewModel = new List<ParcelViewModel>();
            int qntdParcel = 0;
            float vlrTotal = 0;
            float vlr = 0;
            int result = 0;
            float ju = 0;
            TimeSpan dt;
            DateTime dtDue;

            //DateTime dtNow, dtDue ;
            //dtNow = DateTime.UtcNow;
            #region Get Users and Parcels

            IEnumerable<User> _users = this.userRepository.GetAll();
            _mainViewModel = mapper.Map<List<MainViewModel>>(_users);
            foreach (var item in _mainViewModel)
            {
                if (item.Id > 0)
                {
                    IEnumerable<Parcel> _parcels = this.parcelRepository.FindAllParcels(item.Id);
                    _parcelViewModel = mapper.Map<List<ParcelViewModel>>(_parcels);
                    dtDue = _parcelViewModel.OrderBy(x => x.DateDue).FirstOrDefault().DateDue;
                    dt = (DateTime.UtcNow - dtDue);
                    result = dt.Days;
                    foreach (var l in _parcelViewModel)
                    {
                        vlr = vlr + l.VlrParcel;
                        qntdParcel = qntdParcel + 1;
                        var hrs = (DateTime.UtcNow - l.DateDue);
                        float p = (l.Fees / 100);
                         ju = ju +((p/30)* hrs.Days* l.VlrParcel);
                    }
                    
                    MainViewModel _ResViewModel = mapper.Map<MainViewModel>(_parcelViewModel.First());
                    vlrTotal = vlr * (_ResViewModel.Fine / 100) + ju;
                    if (result < 0)
                        result = 0;



                    _ResViewModel.VlrParcel = vlr;
                    _ResViewModel.dtLate = result;
                    _ResViewModel.NumParcel = qntdParcel;
                    _ResViewModel.Name = item.Name;
                    _ResViewModel.CPF = item.CPF;
                    _ResViewModel.TitleNumber = item.TitleNumber;
                    _ResViewModel.ValTotal = vlrTotal + vlr;
                    _ResViewModel.Id = item.Id;

                    _resultViewModel.Add(_ResViewModel);
                    qntdParcel = 0;
                    vlrTotal = 0;
                    ju = 0;
                    vlr = 0;
                }
                else
                {
                    throw new Exception("UserId is not valid");
                }
            }
            #endregion
            //_resultViewModel = mapper.Map<List<MainViewModel>>(_mainViewModel);
            //_resultViewModel = mapper.Map<List<MainViewModel>>(_parcels);

           

           

            return _resultViewModel;
        }


        public bool Post(MainViewModel[] mainViewModel)
        {
            User _user = new User();
            User result = new User();
            ArrayList myAL = new ArrayList();
            foreach (var model in mainViewModel)
            {
                if (model.CPF != "" && model.Name != "" && model.TitleNumber > 0)
                {
                    _user.DateCreated = DateTime.UtcNow;
                    _user = mapper.Map<User>(model);
                    result = this.userRepository.Create(_user);
                }
                else {
                    myAL.Add(model);
                }
            
            }

            if (result.Id != 0)
            {
                List<Parcel> _parcel = mapper.Map<List<Parcel>>(myAL);
                foreach (var item in _parcel)
                {
                    item.DateCreated = DateTime.UtcNow;
                    item.IdUser = result.Id;
                }
                this.parcelRepository.Create(_parcel);

            }

            //if ( _user.CPF != "" && _user.Name != "" && _user.TitleNumber > 0 ) {
            //    _user.DateCreated = DateTime.UtcNow;
            //     result = this.userRepository.Create(_user);
            //}


            return true;
        }

        public List<ParcelViewModel> GetById(String Id) {
            if (!int.TryParse(Id, out int userId))
                throw new Exception("UserId is not valid");

            IEnumerable<Parcel> _parcel = this.parcelRepository.FindParcels(userId);

            if (_parcel == null) 
                throw new Exception("User not found");
             
            return  mapper.Map<List<ParcelViewModel>>(_parcel);


        }

        public bool Put(UserViewModel userViewModel) {

            User _user = this.userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            _user = mapper.Map<User>(userViewModel);
            _user.DateUpdated = DateTime.UtcNow;
            this.userRepository.Update(_user);

            return true;
        }

        public bool Delete(string id) {
            if (!int.TryParse(id, out int userId))
                throw new Exception("UserId is not valid");

            User _user = this.userRepository.Find(x => x.Id == userId && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            return this.userRepository.Delete(_user);
        }
    }
}
