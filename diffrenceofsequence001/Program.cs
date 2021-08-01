using System;
using System.Collections.Generic;

namespace diffrenceofsequence001 {
    class Program {
        static void Main() {
            // 件数入力
            var n = Convert.ToInt32(Console.ReadLine());

            var a = Console.ReadLine().Split(' ');
            var b = Console.ReadLine().Split(' ');

            for (var i = 0; i < n; i++) {
                Console.Write($"{(i == 0 ? string.Empty : " ")}{Convert.ToInt32(b[i]) - Convert.ToInt32(a[i])}");
            }
            Console.WriteLine();
        }
    }
}
