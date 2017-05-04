using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class StregsystemCLI : IStregsystemUI{
        private IStregsystem stregsystem;
        private bool active = true;

        public StregsystemCLI(IStregsystem stregsystem) {
            this.stregsystem = stregsystem;
        }

        public void Start() {
            MenuLoop();
        }

        public void Close() {
            active = false;
        }

        private void MenuLoop() {
            while (active == true) {
                Console.Clear();
                DrawMenu();
                Console.WriteLine();
                GetCommand();
            }
        }

        private void DrawMenu() {
            Console.WriteLine("================================================================================");
            Console.WriteLine("||                               STREGSYSTEM 2017                             ||");
            Console.WriteLine("================================================================================");
        }

        private void GetCommand() {
            Console.WriteLine("write a command: ");
            string s = Console.ReadLine();
            Console.WriteLine("you said: " + s + "\n");
        }
    }
}
