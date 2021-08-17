using System;

namespace nthandnthplus1char001 {
    /// <summary>
    /// 文字列の n 文字目と n + 1 文字目
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/count_string_4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var str = Console.ReadLine();

            // 結果の表示
            if (str.Length > n)
                Console.WriteLine($"{str[n - 1]} {str[n]}");
        }
    }
}
