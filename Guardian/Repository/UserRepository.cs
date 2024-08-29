using Guardian.Data;
using Guardian.Models;
using Guardian.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Guardian.Repository
{
    public class UserRepository: IUsersRepository
    {
        private readonly GuardianDB _dbContext;
        public UserRepository(GuardianDB guardianDB) 
        {
            _dbContext = guardianDB;
        }
        public async Task<List<Models.UserRepository>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<Models.UserRepository> SearchById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Models.UserRepository> Add(Models.UserRepository user)
        {
           await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<Models.UserRepository> Update(Models.UserRepository user, int id)
        {
            Models.UserRepository userbyId = await SearchById(id);

            if (userbyId == null) 
            {
                throw new Exception($"Usuário:{id} não encontrado no banco de dados!");
            }
            
            userbyId.Name = user.Name;
            userbyId.Email = user.Email;

            _dbContext.Users.Update(userbyId);
           await _dbContext.SaveChangesAsync();

            return userbyId;

        }

        public async Task<bool> Delete(int id)
        {
            Models.UserRepository userbyId = await SearchById(id);

            if (userbyId == null)
            {
                throw new Exception($"Usuário:{id} não encontrado no banco de dados!");
            }

            _dbContext.Users.Remove(userbyId);
            await _dbContext.SaveChangesAsync(); 
            return true;

        }


    }
}
