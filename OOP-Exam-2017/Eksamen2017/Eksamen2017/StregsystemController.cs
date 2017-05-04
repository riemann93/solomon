﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class StregsystemController {

        public IStregsystemUI stregsystemUI;
        public IStregsystem stregsystem;

        public StregsystemController(IStregsystem stregsystem, IStregsystemUI stregsystemUI) {
            this.stregsystemUI = stregsystemUI;
            this.stregsystem = stregsystem;
        }
    }
}