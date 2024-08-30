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
        public async Task<ActionResult<List<UserModel>>> SearchAllUsers()
        {
            List<UserModel> Users = await _usersRepository.SearchAllUsers();
            return Ok(Users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<UserModel>>> SearchById(int id)
        {
            UserModel Users = await _usersRepository.SearchById(id);
            return Ok(Users);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> Cadastrar([FromBody] UserModel usersModel)
        {
            UserModel users = await _usersRepository.Add(usersModel);
            return Ok(users);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> Update([FromBody] UserModel usersModel, int id)
        {
            UserModel users = await _usersRepository.Update(usersModel, id);
            return Ok(users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> Delete(int id)
        {
            bool deleted = await _usersRepository.Delete(id);
            return Ok(deleted);
        }

        [HttpGet("{ImageRandom}")]
        public IActionResult GetRandomImage()
        {
            // URL do serviço de imagens aleatórias
            var randomImageUrl = "https://picsum.photos/id/1/200/300";

            return Ok(new { imageUrl = randomImageUrl });
        }
    }
}

