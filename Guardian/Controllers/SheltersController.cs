using Guardian.Models;
using Guardian.Repository;
using Guardian.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guardian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheltersController : ControllerBase
    {
        private readonly IShelterRepository _shelterRepository;

        public SheltersController(IShelterRepository shelterRepository)
        {
            _shelterRepository = shelterRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ShelterModel>>> SearchAllShelter()
        {
            List<ShelterModel> shelter = await _shelterRepository.SearchAllShelter();
            return Ok(shelter);
        }

        [HttpPost]
        public async Task<ActionResult<ShelterModel>> Cadastrar([FromBody] ShelterModel shelterModel) 
        {
            ShelterModel shelter = await _shelterRepository.Add(shelterModel);
            return Ok(shelter);
        }
    }
}
