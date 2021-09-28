using System;
using System.Collections.Generic;

namespace findvaluepos002 {
    /// <summary>
    /// 指定された値の位置 2
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // nは使わない
            _ = Convert.ToInt32(Console.ReadLine());

            // 検索される配列
            var values = Console.ReadLine().Split(' ');

            var targetValue = Console.ReadLine();

            // 答え
            var answers = new List<int>();

            for (var i = 0; i < values.Length; i++) {
                if (values[i] == targetValue) answers.Add(i);
            }

            // 結果の表示
            Console.WriteLine(answers.Count > 0 ? answers[answers.Count -1] + 1 : 0);
        }
    }
}
