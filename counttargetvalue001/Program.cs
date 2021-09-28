using System;

namespace counttargetvalue001 {
    /// <summary>
    /// 指定された値の個数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_step0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // nは使わない
            _ = Convert.ToInt32(Console.ReadLine());

            // 検索される配列
            var values = Console.ReadLine().Split(' ');

            var targetValue = Console.ReadLine();

            var cnt = 0;
            for (var i = 0; i < values.Length; i++) {
                if (values[i] == targetValue) cnt++;
            }

            // 結果の表示
            Console.WriteLine(cnt);
        }
    }
}
