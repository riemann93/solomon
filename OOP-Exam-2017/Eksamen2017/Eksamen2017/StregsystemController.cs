using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class StregsystemController {

        private StregsystemCLI stregsystemUI;
        private Stregsystem stregsystem;

        public StregsystemController(StregsystemCLI stregsystemUI, Stregsystem stregsystem) {
            this.stregsystemUI = stregsystemUI;
            this.stregsystem = stregsystem;
        }
    }
}
