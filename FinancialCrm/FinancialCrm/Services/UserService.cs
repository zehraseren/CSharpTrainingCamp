using System.Linq;
using FinancialCrm.Models;

namespace FinancialCrm.Services
{
    public class UserService
    {
        private readonly FinancialCrmDbEntities _db;

        public UserService(FinancialCrmDbEntities db)
        {
            _db = db;
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == username);
            if (user != null && VerifyPassword(user.Password, password))
            {
                return true;
            }
            return false;
        }

        private bool VerifyPassword(string storedPassword, string enteredPassword)
        {
            return storedPassword == enteredPassword;
        }
    }
}
