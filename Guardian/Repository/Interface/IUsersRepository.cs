using Guardian.Models;

namespace Guardian.Repository.Interface
{
    public interface IUsersRepository
    {
        Task<List<Models.UserRepository>> SearchAllUsers();
        Task<Models.UserRepository> SearchById(int id);
        Task<Models.UserRepository> Add(Models.UserRepository user);
        Task<Models.UserRepository> Update(Models.UserRepository user, int id);
        Task<bool> Delete(int id);
        
    }
}
