using System;
using System.Collections.Generic;

namespace onlyoneitemperperson001 {
    /// <summary>
    /// お一人様一点限り
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/c2_one_item/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var users = new Dictionary<string, bool>();
            var answers = new List<string>(n);

            for (var i = 0; i < n; i++) {
                var user = Console.ReadLine();
                if (users.ContainsKey(user)) {
                    answers.Add("NO");
                } else {
                    users.Add(user, true);
                    answers.Add("YES");
                }
            }

            // 結果を表示
            answers.ForEach(a => Console.WriteLine(a));
        }
    }
}
