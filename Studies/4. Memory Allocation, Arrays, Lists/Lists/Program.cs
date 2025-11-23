using System.Collections.Generic;

namespace Lists {
    internal class Program {
        static void Main(string[] args) {
            // Lists are dynamic arrays that can grow and shrink in size.
            // There's no need to define an initial size, or to initialize all elements.
            // Its downside is that they use more memory and are slightly slower than arrays.

            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Alex", "Mary" };

        }
    }
}
