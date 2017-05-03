using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class StregsystemCLI : IStregsystemUI{
        private Stregsystem stregsystem;
        private bool active = true;
        private string test;

        public StregsystemCLI(Stregsystem stregsystem) {
            this.stregsystem = stregsystem;
        }

        public void Start() {
            while (active == true) {
                Console.Clear();
                DrawMenu();
                Console.WriteLine();
                GetCommand();
            }
        }

        private void DrawMenu() {
            Console.WriteLine("================================================================================");
            Console.WriteLine("||                               STREGSYSTEM 2017" + test + "                 ||");
            Console.WriteLine("================================================================================");
        }

        private void GetCommand() {
            Console.WriteLine("write a command: ");
            string s = Console.ReadLine();
            Console.WriteLine("you said: " + s + "\n");
        }
    }
}
