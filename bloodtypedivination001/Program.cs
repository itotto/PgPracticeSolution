using System;
using System.Collections.Generic;

namespace bloodtypedivination001 {
    /// <summary>
    /// 1つの血液型を占う
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 検索対象者
            var targetBloodType = Console.ReadLine();

            // 件数
            var m = Convert.ToInt32(Console.ReadLine());

            var data = new Dictionary<string, string>(m);
            for (var i = 0; i < m; i++) {
                var inputs = Console.ReadLine().Split(' ');
                data.Add(inputs[0], inputs[1]);
            }

            // 結果を表示
            Console.WriteLine(data[targetBloodType]);
        }
    }
}
