using Guardian.Models;

namespace Guardian.Repository.Interface
{
    public interface IUsersRepository
    {
        Task<List<Models.UserModel>> SearchAllUsers();
        Task<Models.UserModel> SearchById(int id);
        Task<Models.UserModel> Add(Models.UserModel user);
        Task<Models.UserModel> Update(Models.UserModel user, int id);
        Task<bool> Delete(int id);
        
    }
}
