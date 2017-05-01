using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class User
    {
        public string Name;
        public int M;

        public User(string name = "", int m = 0)
        {
            m = M;
            Name = name;
        }

        public void addm(int m)
        {
            M = M + m;
        }

        public bool subm(int m)
        {
            if (M - m > 0)
            {
                M = M - m;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
