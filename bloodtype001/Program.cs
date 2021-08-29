using System;
using System.Collections.Generic;

namespace bloodtype001 {
    /// <summary>
    /// 1人の血液型
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 検索対象者
            var targetUserName = Console.ReadLine();

            // 件数
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new Dictionary<string, string>(n);
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                data.Add(inputs[0], inputs[1]);
            }

            // 結果を表示
            Console.WriteLine($"{targetUserName} {data[targetUserName]}");
        }
    }
}
