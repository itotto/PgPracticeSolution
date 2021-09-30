using System;

namespace oddsearch001 {
    /// <summary>
    /// 奇数の探索
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var inputs = Console.ReadLine().Split(' ');

            var pos = -1;
            for (var i = inputs.Length - 1; i >= 0; i--) {
                if (Convert.ToInt32(inputs[i]) % 2 == 1) {
                    pos = i;
                    break;
                }
            }

            // 結果の表示
            Console.WriteLine(pos + 1);
        }
    }
}
