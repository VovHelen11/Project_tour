using System.Collections.Generic;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        
        private readonly Mapper _mapper;

        public UserService(Mapper mapper, IRepository<User> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void AddUser(UserBL userBl)
        {
            _repository.Add(_mapper.Map<UserBL, User>(userBl));
        }

        public void Block(int id)
        {
           var user= _repository.GetById(id);

           user.Block = true;
           _repository.Update(user);
        }

        public UserBL GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserBL> GetUsers()
        {
            var users=_repository.GetAll();
            var mapUsers = _mapper.Map<IEnumerable<User>, IEnumerable<UserBL>>(users);

            return mapUsers;
        }

        public void Unblock(int id)
        {

            var user = _repository.GetById(id);

            user.Block = false;
            _repository.Update(user);
        }

       
    }
}