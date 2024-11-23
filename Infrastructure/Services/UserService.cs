using Application.Dtos.Users;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entity;

namespace Infrastructure.Services
{
    public class UserService : IUserServices
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void AddUser(CreatedUserDto user)
        {
            IDictionary<string, string> errors = ValidateUser(user);

            if(errors.Count > 0)
            {
                throw new ArgumentException("User is not valid", nameof(user));
            }

            var userEntity = _mapper.Map<User>(user);

            _userRepository.Insert(userEntity);
        }

        public User GetUser(int Id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string UserName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int Id, CreatedUserDto user)
        {
            throw new NotImplementedException();
        }

        private IDictionary<string, string> ValidateUser(CreatedUserDto user)
        {
            IDictionary<string, string> errors = new Dictionary<string, string>();
            
            if(string.IsNullOrEmpty(user.Username))
            {
                errors.Add("Username", "Username is required");
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                errors.Add("Password", "Password is required");
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                errors.Add("Email", "Email is required");
            }

            return errors;
        }
    }
}
