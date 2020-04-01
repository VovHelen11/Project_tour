﻿using System.Collections.Generic;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        
        private readonly Mapper _mapper;

        public UserService(Mapper mapper, IRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public void AddUser(UserBL userBl)
        {
            _userRepository.Add(_mapper.Map<UserBL, User>(userBl));
        }

        public void Block(int id)
        {
           var user= _userRepository.GetById(id);

           user.Block = true;
           _userRepository.Update(user);
        }

        public UserBL GetUser(int id)
        {
            var user = _userRepository.GetById(id);
            var mapUser = _mapper.Map<User, UserBL>(user);

            return mapUser;
        }

        public IEnumerable<UserBL> GetUsers()
        {
            var users=_userRepository.GetAll();
            var mapUsers = _mapper.Map<IEnumerable<User>, IEnumerable<UserBL>>(users);

            return mapUsers;
        }

        public void Unblock(int id)
        {

            var user = _userRepository.GetById(id);

            user.Block = false;
            _userRepository.Update(user);
        }

       
    }
}