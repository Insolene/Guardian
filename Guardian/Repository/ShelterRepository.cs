using Guardian.Data;
using Guardian.Models;
using Guardian.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Guardian.Repository
{
    public class ShelterRepository: IShelterRepository
    {
        private readonly GuardianDB _dbContext;
        public ShelterRepository(GuardianDB guardianDB) 
        {
            _dbContext = guardianDB;
        }
        public async Task<List<ShelterModel>> SearchAllShelter()
        {
            return await _dbContext.Shelters.ToListAsync();
        }
        public async Task<ShelterModel> Add(ShelterModel shelter)
        {
            await _dbContext.Shelters.AddAsync(shelter);
            await _dbContext.SaveChangesAsync();

            return shelter;
        }

    }
}
