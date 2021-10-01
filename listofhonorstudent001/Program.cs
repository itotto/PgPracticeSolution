using System;
using System.Collections.Generic;

namespace listofhonorstudent001 {
    /// <summary>
    /// 成績優秀者の列挙 1
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step6/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 成績
            var grades = new List<KeyValuePair<string, int>>(n);
            for (var i = 0; i < n; i++) {
                var g_input = Console.ReadLine().Split(' ');
                grades.Add(new KeyValuePair<string, int>(g_input[0],Convert.ToInt32(g_input[1])));
            }

            // 合格点
            var pscore = Convert.ToInt32(Console.ReadLine());

            grades.ForEach(g => {
                if (g.Value >= pscore) Console.WriteLine(g.Key);
            });
        }
    }
}
