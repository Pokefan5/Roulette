using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_App
{
    class User
    {
        public string name;
        public int balance;

        public User(string n, int b)
        {
            this.name = n;
            this.balance = b;
        }
    }
}
