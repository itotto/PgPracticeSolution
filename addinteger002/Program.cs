using System;

namespace addinteger002 {
    /// <summary>
    /// 整数の足し算
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var sum = 0;

            for (var i = 0; i < inputs.Length; i++) sum += Convert.ToInt32(inputs[i]);

            // 結果の表示
            Console.WriteLine(sum);
        }
    }
}
