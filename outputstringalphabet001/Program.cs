using System;

namespace outputstringalphabet001 {
    /// <summary>
    /// アルファベットの範囲の文字の出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/alphabets_large_or_small_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var str = Console.ReadLine();
            for (var c = str[0]; c <= str[str.Length - 1]; c++) {
                Console.WriteLine(c);
            }
        }
    }
}
