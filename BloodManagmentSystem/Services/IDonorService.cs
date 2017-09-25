using BloodManagmentSystem.Models;

namespace BloodManagmentSystem.Services
{
    public interface IDonorService
    {
        void Add(Donor donor);
        void Save();
    }
}