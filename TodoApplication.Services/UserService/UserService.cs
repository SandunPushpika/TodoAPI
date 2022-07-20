using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.DataAccess;
using TodoApplication.Models;

namespace TodoApplication.Services.UserService {
    public class UserService : IUserService {

        private readonly DContext _context = new DContext();
        public ApplicationUser AddUser(ApplicationUser user) {
            _context.users.Add(user);
            _context.SaveChanges();
            return _context.users.Find(user.Id);
        }

        public void DeleteUser(int user_id) {
            var user = _context.users.Find(user_id);
            if (user == null) {
                throw new Exception("No User Found!");
            }
            _context.users.Remove(user);
            _context.SaveChanges();
        }

        public List<ApplicationUser> GetAllUsers() {
           return _context.users.ToList();
        }

        public ApplicationUser UpdateUser(ApplicationUser user) {
            _context.users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
