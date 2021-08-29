using System;
using System.Collections.Generic;

namespace divinationresult001 {
    /// <summary>
    /// 1人の占い結果
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 検索対象者
            var targetUserName = Console.ReadLine();

            // 件数
            var n = Convert.ToInt32(Console.ReadLine());

            // key:username, value:bloodtype
            var userdata = new Dictionary<string, string>(n);
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                userdata.Add(inputs[0], inputs[1]);
            }

            // 件数
            var m = Convert.ToInt32(Console.ReadLine());

            // key:bloodtype, value:divination_result
            var blooddivinations = new Dictionary<string, string>(m);
            for (var i = 0; i < m; i++) {
                var inputs = Console.ReadLine().Split(' ');
                blooddivinations.Add(inputs[0], inputs[1]);
            }

            // 結果の表示
            Console.WriteLine(blooddivinations[userdata[targetUserName]]);
        }
    }
}
