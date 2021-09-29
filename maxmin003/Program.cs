using System;

namespace maxmin003 {
    /// <summary>
    /// n 変数の最大最小
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_minmax_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var max = int.MinValue;
            var min = int.MaxValue;

            _ = Convert.ToInt32(Console.ReadLine());

            var inputs = Console.ReadLine().Split(' ');
            for (var i = 0; i < inputs.Length; i++) {
                var v = Convert.ToInt32(inputs[i]);
                if (v > max) max = v;
                if (v < min) min = v;
            }

            // 結果の表示
            Console.WriteLine($"{max} {min}");
        }
    }
}
