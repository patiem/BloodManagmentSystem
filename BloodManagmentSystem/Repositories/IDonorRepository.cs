using BloodManagmentSystem.Models;
using System.Collections.Generic;

namespace BloodManagmentSystem.Repositories
{
    public interface IDonorRepository
    {
        void Add(Donor donor);
        void Save();
        IEnumerable<Donor> GetAvailableDonorsWithMatchingBloodType(BloodType bloodType);
    }
}