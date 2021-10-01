using System;
using System.Collections.Generic;

namespace listofhonorstudent002 {
    /// <summary>
    /// 成績優秀者の列挙 2
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 成績
            var grades = new List<KeyValuePair<string, int>>(n);
            for (var i = 0; i < n; i++) {
                var g_input = Console.ReadLine().Split(' ');
                grades.Add(new KeyValuePair<string, int>(g_input[0], Convert.ToInt32(g_input[1])));
            }

            // 合格点
            var score_input = Console.ReadLine().Split(' ');
            var pscore_min = Convert.ToInt32(score_input[0]);
            var pscore_max = Convert.ToInt32(score_input[1]);

            grades.ForEach(g => {
                if (pscore_min <= g.Value && g.Value <= pscore_max) Console.WriteLine(g.Key);
            });
        }
    }
}
