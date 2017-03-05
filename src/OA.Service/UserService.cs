using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<UserProfile> _userProfileRepository;

        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
        }
        public void DeleteUser(long id)
        {
            var userProfile = _userProfileRepository.Get(id);
            _userProfileRepository.Remove(userProfile);

            var user = GetUser(id);
            _userRepository.Remove(user);
            _userRepository.SaveChanges();
        }

        public User GetUser(long id)
        {
            return _userRepository.Get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
