using MUB.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MUB.Services
{
    public class AccountService
    {
        public async Task<UserViewModel> GetByUserName(string username)
        {
            if (username == "rr1980")
            {
                return _user();
            }
            else
            {
                return null;
            }
        }

        public async Task<UserViewModel> GetById(int id)
        {
            if (id == 1)
            {
                return _user();
            }
            else
            {
                return null;
            }
        }

        private static UserViewModel _user()
        {
            return new UserViewModel()
            {
                UserId = 1,
                Name = "Riesner",
                Vorname = "Rene",
                Anrede = 0,
                Username = "rr1980",
                Password = "12003",
                Roles = new int[] {0,1,2}
            };
        }
    }
}
