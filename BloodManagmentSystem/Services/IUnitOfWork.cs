using BloodManagmentSystem.Repositories;

namespace BloodManagmentSystem.Services
{
    public interface IUnitOfWork
    {
        IDonorRepository Donors { get; set; }
    }
}