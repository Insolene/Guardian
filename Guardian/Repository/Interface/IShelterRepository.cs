using Guardian.Models;
using System.Threading.Tasks;

namespace Guardian.Repository.Interface
{
    public interface IShelterRepository
    {
        Task<List<ShelterModel>> SearchAllShelter();
        Task<ShelterModel> Add(ShelterModel shelter);

    }
}
