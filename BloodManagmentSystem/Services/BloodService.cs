using BloodManagmentSystem.Controllers;
using BloodManagmentSystem.Repositories;

namespace BloodManagmentSystem.Services
{
    public class BloodService : IBloodService
    {
        private readonly IBloodRepository _repo;

        public BloodService(IBloodRepository repo)
        {
            _repo = repo;
        }

        public object Get()
        {
            return _repo.Get();
        }

        public void Add()
        {
            _repo.Add();
        }
    }
}