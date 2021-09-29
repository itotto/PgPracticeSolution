using System;

namespace maxmin001 {
    /// <summary>
    /// 2変数の最大最小
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_minmax_step0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var v1 = Convert.ToInt32(inputs[0]);
            var v2 = Convert.ToInt32(inputs[1]);
            var min = v1 > v2 ? v2 : v1;
            var max = v1 > v2 ? v1 : v2;

            // 結果の表示
            Console.WriteLine($"{max} {min}");
        }
    }
}
