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
        private string name;

        public User()
        {
            money = 1000; //money when programm is started
        }

        public int Money // property money
        {
            get { return money; }
            set { money = value; }
        }

        public string Name // property name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
