using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoApplication.Models;
using TodoApplication.Services.Models;
using TodoApplication.Services.UserService;

namespace TodoApplication.Controllers {
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller {
        private readonly IUserService _service;
        private readonly IMapper _mapper;
        public UserController(IUserService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<UserModel>> GetAllUsers() {
            var users = _mapper.Map<ICollection<UserModel>>(_service.GetAllUsers());
            return Ok(users);
        }

        [HttpPost]
        public ActionResult<UserModel> AddUser(ApplicationUser user){ 
            var addeduser = _service.AddUser(user);
            return Created("Added a user",_mapper.Map<UserModel>(addeduser));
        }
        [HttpPut]
        public ActionResult UdateUser(ApplicationUser user) {
            _service.UpdateUser(user);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult DeleteUser([FromQuery] int userid) { 
            _service.DeleteUser(userid);
            return NoContent();
        }

    }
}
