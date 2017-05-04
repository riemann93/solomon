//20135447_Steffan_Riemann_Hansen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class Program {
        static void Main(string[] args) {

            IStregsystem stregsystem = new Stregsystem();
            IStregsystemUI ui = new StregsystemCLI(stregsystem);
            StregsystemController sc = new StregsystemController(stregsystem, ui);

            ui.Start();
        }
    }
}
