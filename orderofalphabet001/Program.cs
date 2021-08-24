using System;

namespace orderofalphabet001 {
    /// <summary>
    /// アルファベットの順番
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/problem_index?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var str = Console.ReadLine();
            Console.WriteLine(str[0] < str[str.Length - 1] ? "true" : "false");
        }
    }
}
