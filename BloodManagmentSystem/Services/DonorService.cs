using BloodManagmentSystem.Models;
using BloodManagmentSystem.Repositories;

namespace BloodManagmentSystem.Services
{
    public class DonorService : IDonorService
    {
        private readonly IDonorRepository _repo;

        public DonorService(IDonorRepository repo)
        {
            _repo = repo;
        }
        public void Add(Donor donor)
        {
            _repo.Add(donor);
        }

        public void Save()
        {
            _repo.Save();
        }
    }
}