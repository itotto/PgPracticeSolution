using System;

namespace duplicationcountofchar001 {
    /// <summary>
    /// 文字の重複カウント
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/string_count_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var cnt = 0;
            var targetChar = Console.ReadLine()[0];
            foreach (var c in Console.ReadLine()) {
                if (c == targetChar) cnt++;
            }
            Console.WriteLine(cnt);

        }
    }
}
