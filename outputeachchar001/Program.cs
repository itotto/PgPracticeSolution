using System;
using System.Linq;

namespace outputeachchar001 {
    class Program {
        static void Main() => Console.ReadLine().ToList().ForEach(c => Console.WriteLine(c));
    }
}
