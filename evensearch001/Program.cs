using System;

namespace evensearch001 {
    /// <summary>
    /// 偶数の探索
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var inputs = Console.ReadLine().Split(' ');

            var pos = -1;
            for (var i = 0; i < inputs.Length; i++) {
                if (Convert.ToInt32(inputs[i]) % 2 == 0) {
                    pos = i;
                    break;
                }
            }

            // 結果の表示
            Console.WriteLine(pos + 1);
        }
    }
}
