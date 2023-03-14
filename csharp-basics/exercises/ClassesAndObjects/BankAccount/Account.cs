using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        private string _userAccountName;
        private decimal _userAccountBalance;
        private string _userAccountDetails;

        public Account(string userAccountName, decimal userAccountBalance)
        {
            _userAccountName = userAccountName;
            _userAccountBalance = userAccountBalance;
        }

        public string ShowUserNameAndBalance()
        {
            var format = $"{Math.Abs(_userAccountBalance):0.00}";

            if (_userAccountBalance < 0)
            {
                return _userAccountDetails = $"{_userAccountName}, -${format}";
            }

            return _userAccountDetails = $"{_userAccountName}, ${format}";
        }
    }
}
