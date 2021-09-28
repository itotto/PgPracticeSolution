using System;

namespace findvaluepos001 {
    /// <summary>
    /// 指定された値の位置 1
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_step1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 個数は使わない
            _ = Convert.ToInt32(Console.ReadLine());

            // n個の文字列
            var values = Console.ReadLine().Split(' ');

            // 検索したい数値
            var targetValue = Console.ReadLine();

            var pos = -1;

            for (var i = 0; i < values.Length; i++) {
                if (values[i] == targetValue) {
                    pos = i;
                    break;
                }
            }

            // 結果の表示
            Console.WriteLine(pos + 1);
        }
    }
}
