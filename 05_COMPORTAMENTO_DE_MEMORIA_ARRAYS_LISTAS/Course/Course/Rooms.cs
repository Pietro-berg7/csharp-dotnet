using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class Rooms {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() {
            return Room
                + ": "
                + Name
                + ", "
                + Email;
        }

    }
}
