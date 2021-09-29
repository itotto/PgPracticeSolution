using System;

namespace maxmin002 {
    /// <summary>
    /// 10変数の最大最小
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_minmax_step1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var max = int.MinValue;
            var min = int.MaxValue;
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
