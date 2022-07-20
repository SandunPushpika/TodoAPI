using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Models;

namespace TodoApplication.Services.UserService {
    public interface IUserService {
        public List<ApplicationUser> GetAllUsers();
        public ApplicationUser AddUser(ApplicationUser user);
        public ApplicationUser UpdateUser(ApplicationUser user);
        public void DeleteUser(int user_id);
    }
}
