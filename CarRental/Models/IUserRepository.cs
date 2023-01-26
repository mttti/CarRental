namespace CarRental.Models
{
    public interface IUserRepository
    {
        IEnumerable<AppUser> users { get; }
        void Edit(AppUser user);
        AppUser Delete(string id);
    }
}
