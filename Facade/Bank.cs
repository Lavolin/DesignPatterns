using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Bank : IBank
    {
        public void DoTransaction()
        {
            User user = new User();
            user.Checkrisk();

            Account account = new Account();
            account.Checkamount();

            Risk risk = new Risk();
            risk.CheckUser();
            risk.CheckTransaction();
        }
    }
}
