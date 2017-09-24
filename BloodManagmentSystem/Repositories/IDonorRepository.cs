using BloodManagmentSystem.Models;

namespace BloodManagmentSystem.Repositories
{
    public interface IDonorRepository
    {
        void Add(Donor donor);
        void Save();
    }
}