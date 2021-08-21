using System;
using System.Collections.Generic;
using System.Linq;

namespace charandnumberpairsort002 {
    /// <summary>
    /// 文字と整数の組のソート2
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_add_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 件数
            var n = Convert.ToInt32(Console.ReadLine());

            var sums = new Dictionary<char, int>();
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                var key = inputs[0][0];
                var value = Convert.ToInt32(inputs[1]);

                if (sums.ContainsKey(key)) sums[key] += value;
                else sums.Add(key, value);
            }

            var answers = sums.ToList();
            answers.Sort((x, y) => y.Value - x.Value);
            answers.ForEach(a => Console.WriteLine($"{a.Key} {a.Value}"));
        }
    }
}
