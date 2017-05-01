using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class StregsystemCLI {
        private Stregsystem stregsystem;
        private bool active = true;

        public StregsystemCLI(Stregsystem stregsystem) {
            this.stregsystem = stregsystem;
        }

        private void Start() {
            while (active == true) {
                Console.Clear();
                drawMenu();
                Console.WriteLine();
                GetCommand();
            }
        }

        private void drawMenu() {
            Console.WriteLine("================================================================================");
            Console.WriteLine("||                               STREGSYSTEM 2017                             ||");
            Console.WriteLine("================================================================================");
        }

        private void GetCommand() {
            Console.WriteLine("write a command: ");
            string s = Console.ReadLine();
            Console.WriteLine("you said: " + s + "\n");
            Console.ReadKey();
        }
    }
}
