using Bonus.MvcWebApp.BusinessServices.Interfaces;

namespace Bonus.MvcWebApp.BusinessServices.Providers
{
    public class UserServices : IUserServices
    {
        public int Authenticate(string userName, string password)
        {
           /* var user = _unitOfWork.UserRepository.Get(u => u.UserName == userName && u.Password == password);
            if (user != null && user.UserId > 0)
            {
                return user.UserId;
            }*/
            return 0;
        }
    }
}