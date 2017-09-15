using BloodManagmentSystem.ViewModels;

namespace BloodManagmentSystem.Repositories
{
    public interface IBloodRepository
    {
        BloodRequestFormViewModel Get();
        void Add();
    }
}