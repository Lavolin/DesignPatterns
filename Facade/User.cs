using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class User
    {
        public Account Account { get; set; }

        public void Checkrisk()
        {
            throw new NotImplementedException();
        }
    }
}
