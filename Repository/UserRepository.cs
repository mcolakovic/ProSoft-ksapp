using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class UserRepository
    {
        private static UserRepository instance;
        List<User> users = new List<User>();
        public User CurrentUser { get; set; }

        private UserRepository()
        {
            users.Add(new User
            {
                Username = "admin1"
            });
            users.Add(new User
            {
                Username = "admin2"
            });
            users.Add(new User
            {
                Username = "user1"
            });
            users.Add(new User
            {
                Username = "user2"
            });
        }
        public static UserRepository Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserRepository();
                return instance;
            }
        }

        public User VratiUsera(User user)
        {
            return users.SingleOrDefault(x => x.Username == user.Username);
        }
    }
}
