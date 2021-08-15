using System;

namespace specificrangeinteger001 {
    /// <summary>
    /// あいだの整数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_upper_5/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var start = Convert.ToInt32(inputs[0]);
            var end = Convert.ToInt32(inputs[1]);
            for (var i = start; i <= end; i++) Console.WriteLine(i);
        }
    }
}
