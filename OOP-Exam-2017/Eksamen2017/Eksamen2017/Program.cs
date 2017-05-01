using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class Program {
        static void Main(string[] args) {

            Stregsystem stregsystem = new Stregsystem();
            StregsystemCLI ui = new StregsystemCLI(stregsystem);

            ui.Start();

        }
    }
}
