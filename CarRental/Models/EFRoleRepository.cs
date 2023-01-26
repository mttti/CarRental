using Microsoft.AspNetCore.Identity;

namespace CarRental.Models
{
    public class EFRoleRepository : IRoleRepository
    {
        private AppDbContext _appDbContext;
        private RoleManager<IdentityRole> _roleManager;

        public EFRoleRepository(AppDbContext appDbContext, RoleManager<IdentityRole> roleManager)
        {
            _appDbContext = appDbContext;
            _roleManager = roleManager;
        }

        public IEnumerable<IdentityRole> roles => _appDbContext.Roles;

        public IdentityRole Delete(string id)
        {
            var role = _appDbContext.Roles.FirstOrDefault(x => x.Id == id);
            if (role != null)
            {
                _appDbContext.Roles.Remove(role);
                _appDbContext.SaveChanges();
            }
            return role;
        }

        public void Edit(IdentityRole role)
        {
            if (!_appDbContext.Roles.Any(i=>i.Id == role.Id))
            {
                _roleManager.CreateAsync(role);
            }
            else
            {
                var roleEntry = _roleManager.FindByIdAsync(role.Id).Result;

                if (roleEntry != null)
                {
                    roleEntry.Name= role.Name;
                    roleEntry.ConcurrencyStamp = Guid.NewGuid().ToString();
                }
            }
            _appDbContext.SaveChanges();
        }
    }
}
