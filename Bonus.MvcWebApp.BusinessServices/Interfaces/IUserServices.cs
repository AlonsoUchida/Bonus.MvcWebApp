
namespace Bonus.MvcWebApp.BusinessServices.Interfaces
{
    public interface IUserServices
    {
        int Authenticate(string userName, string password);
    }
}
