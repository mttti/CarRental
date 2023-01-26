using Microsoft.AspNetCore.Identity;

namespace CarRental.Models
{
    public class EFUserRepository : IUserRepository
    {
        private UserManager<AppUser> _user;
        private AppDbContext _context;

        public EFUserRepository(UserManager<AppUser> user, AppDbContext context)
        {
            _user = user;
            _context = context;
        }

        public IEnumerable<AppUser> users => _user.Users;

        public AppUser Delete(string id)
        {
            AppUser user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }

        public void Edit(AppUser user)
        {
            if (!_context.Users.Any(i=>i.Id==user.Id))
            {
                _context.Add(user);
            }
            else
            {
                var userEntry = _user.FindByIdAsync(user.Id).Result;

                if (userEntry != null)
                {                   
                    _user.AddToRoleAsync(user, user.Role);
                    _user.SetUserNameAsync(userEntry, user.UserName);
                    userEntry.Email = user.Email;
                    userEntry.NormalizedEmail = user.Email.ToUpper();
                    userEntry.Name = user.Name;
                    userEntry.LastName = user.LastName;
                    userEntry.PhoneNumber = user.PhoneNumber;
                    userEntry.Role = user.Role;
                    
                }
            }
            _context.SaveChanges();
        }

    }
}
