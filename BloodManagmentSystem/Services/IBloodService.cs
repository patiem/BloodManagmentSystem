using BloodManagmentSystem.ViewModels;

namespace BloodManagmentSystem.Services
{
    public interface IBloodService
    {
        BloodRequestFormViewModel Get();
        void Add();
    }
}