using System;

namespace addinteger003 {
    /// <summary>
    /// 整数の足し算 
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_upper_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var v = Console.ReadLine().Split(' ');

            // 結果の表示
            Console.WriteLine(Convert.ToInt32(v[0]) + Convert.ToInt32(v[1]));
        }
    }
}
