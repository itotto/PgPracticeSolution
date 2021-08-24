using System;
using System.Collections.Generic;

namespace outputstring001 {
    /// <summary>
    /// 文字列の出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/alphabets_large_or_small_0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int COUNT = 3;
            var inputs = new List<string>(COUNT);
            for (var i = 0; i < COUNT; i++) {
                inputs.Add(Console.ReadLine());
            }

            // 結果の表示
            inputs.ForEach(i => Console.WriteLine(i));
        }
    }
}
