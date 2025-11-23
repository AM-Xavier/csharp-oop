using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs {
    struct Point {

        // A struct can have fields, properties, and methods, just like a class, the difference being that structs are value types
        // and are typically used for small data structures.
        // While classes are reference types and are allocated on the heap, structs are value types and are usually allocated on the stack.
        
        public double X;
        public double Y;

        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
    }
}
