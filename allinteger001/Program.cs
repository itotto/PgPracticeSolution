using System;

namespace allinteger001 {
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var start = Convert.ToInt32(inputs[0]);
            var end = Convert.ToInt32(inputs[1]);
            for (var i = start; i <= end; i++) Console.WriteLine(i);
        }
    }
}
