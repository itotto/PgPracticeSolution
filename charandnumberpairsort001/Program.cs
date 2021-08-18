using System;
using System.Collections.Generic;

namespace charandnumberpairsort001 {
    /// <summary>
    /// 文字と整数の組のソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_asc_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 入力値の数
            var n = Convert.ToInt32(Console.ReadLine());

            // 入力値
            var data = new List<KeyValuePair<string, int>>(n);
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                data.Add(new KeyValuePair<string, int>(inputs[0], Convert.ToInt32(inputs[1])));
            }

            // ソート
            data.Sort((x, y) => x.Value - y.Value);

            // 結果を表示
            data.ForEach(d => Console.WriteLine(d.Key));
        }
    }
}
