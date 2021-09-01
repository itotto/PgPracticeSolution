using System;

namespace mranonymous001 {
    /// <summary>
    /// 匿名希望さん
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d6_initial/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            Console.WriteLine($"{inputs[0][0]}.{inputs[1][0]}.");
        }
    }
}
