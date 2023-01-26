using Microsoft.AspNetCore.Identity;

namespace CarRental.Models
{
    public interface IRoleRepository
    {
        IEnumerable<IdentityRole> roles{ get; }

        void Edit(IdentityRole role);
        IdentityRole Delete(string id);
    }
}
