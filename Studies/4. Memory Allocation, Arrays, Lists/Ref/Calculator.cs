using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref {
    internal class Calculator {
        // Reference types allow you to pass arguments by reference, enabling methods to modify the original variable's value.
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}
