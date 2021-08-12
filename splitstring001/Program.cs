using System;

namespace splitstring001 {
    /// <summary>
    /// 文字列の分割
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');

            // 結果の表示
            for (var i = 0; i < inputs.Length; i++) {
                Console.WriteLine(inputs[i]);
            }
        }
    }
}
