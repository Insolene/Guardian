using Guardian.Models;
using Guardian.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guardian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserRepository>>> SearchAllUsers()
        {
            List<UserRepository> Users = await _usersRepository.SearchAllUsers();
            return Ok(Users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<UserRepository>>> SearchById(int id)
        {
            UserRepository Users = await _usersRepository.SearchById(id);
            return Ok(Users);
        }

        [HttpPost]
        public async Task<ActionResult<UserRepository>> Cadastrar([FromBody] UserRepository usersModel)
        {
            UserRepository users = await _usersRepository.Add(usersModel);
            return Ok(users);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserRepository>> Update([FromBody] UserRepository usersModel, int id)
        {
            UserRepository users = await _usersRepository.Update(usersModel, id);
            return Ok(users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserRepository>> Delete(int id)
        {
            bool deleted = await _usersRepository.Delete(id);
            return Ok(deleted);
        }
    }
}

