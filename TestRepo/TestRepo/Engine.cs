using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class Engine
    {
        List<User> Users = new List<User>();
        List<Pro> Pros = new List<Pro>();

        public Engine()
        {
            
        }

        public void LoadPros()
        {
            Pro p1 = new Pro() { Name = "en", Number = 10 };
            Pro p2 = new Pro() { Name = "to", Number = 20 };

            Pros.Add(p1);
            Pros.Add(p2);

        }

        public bool AddPro(string name, int n)
        {
            foreach (Pro pro in Pros)
            {
                if (pro.Name == name)
                {
                    return false;
                }
            }

            Pro p = new Pro() { Name = name, Number = n };

            Pros.Add(p);

            return true;
        }

        public bool DelPro(string name)
        {
            var proToDel = Pros.SingleOrDefault(p => p.Name == "name");

            if(proToDel != null)
            {
                Pros.Remove(proToDel);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadUsers()
        {
            User u1 = new User() { Name = "ste", M = 100 };
            User u2 = new User() { Name = "ran", M = 500 };

            Users.Add(u1);
            Users.Add(u2);
        }

        public bool AddUser(string name, int m)
        {
            foreach (User user in Users)
            {
                if (user.Name == name)
                {
                    return false;
                }
            }

            User u = new User() { Name = name, M = m };

            Users.Add(u);

            return true;
        }

        public bool DelUser(string name)
        {
            var userToDel = Users.SingleOrDefault(u => u.Name == "name");

            if (userToDel != null)
            {
                Users.Remove(userToDel);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
