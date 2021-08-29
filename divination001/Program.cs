using System;
using System.Collections.Generic;

namespace divination001 {
    /// <summary>
    /// 占い
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 件数
            var n = Convert.ToInt32(Console.ReadLine());

            // key:username, value:usertype
            var userdata = new Dictionary<string, string>(n);

            // ユーザーの名前
            var users = new List<string>(n);

            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                users.Add(inputs[0]);
                userdata.Add(inputs[0], inputs[1]);
            }

            // 件数
            var m = Convert.ToInt32(Console.ReadLine());

            // key:usertype, value:divination_result
            var divinations = new Dictionary<string, string>(m);
            for (var i = 0; i < m; i++) {
                var inputs = Console.ReadLine().Split(' ');
                divinations.Add(inputs[0], inputs[1]);
            }

            // 結果の表示
            users.ForEach(u => Console.WriteLine($"{u} {divinations[userdata[u]]}"));
        }
    }
}
