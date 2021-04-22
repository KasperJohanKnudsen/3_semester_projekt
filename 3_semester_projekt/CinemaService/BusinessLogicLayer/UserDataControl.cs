using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public class UserDataControl : IDataControl<User>
    {
        ICRUD<User> _userAccess;
        public UserDataControl(IConfiguration inConfiguration)
        {
            _userAccess = new UserDatabaseAccess(inConfiguration);
        }
        public int Add(User newUser)
        {
            int insertedId;
            try
            {

                insertedId = _userAccess.Create(newUser);
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(int idToMatch)
        {
            User foundUser;
            try
            {
                foundUser = _userAccess.GetById(idToMatch);
            }
            catch
            {
                foundUser = null;
            }
            return foundUser;
        }

        public IEnumerable<User> Get()
        {
            List<User> foundUsers;
            try
            {
                foundUsers = (List<User>)_userAccess.GetAll();
            }
            catch
            {
                foundUsers = null;
            }
            return foundUsers;
        }

        public bool Put(User entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
