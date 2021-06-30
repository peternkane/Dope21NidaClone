using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEEK8APP.DTO;

namespace WEEK8APP.DAO
{
    public interface IUSER
    {
        IList<User> GetAllUsers();

        void CreateUser(User user);

        User GetCurrentUser(long id);

        User UpdateUser(User user);

    }
}
