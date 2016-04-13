using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_App
{
    class User
    {
        private int money;

        public User()
        {
            money = 1000; //money when programm is started
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
