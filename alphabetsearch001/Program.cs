using System;

namespace alphabetsearch001 {
    /// <summary>
    /// アルファベット探し
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/alphabets_large_or_small_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var x = Console.ReadLine()[0];
            var y = Console.ReadLine()[0];
            var c = Console.ReadLine()[0];

            var r = false;

            if (x <= y) {
                r = x <= c && c <= y;
            }

            Console.WriteLine(r ? "true" : "false");
        }
    }
}
