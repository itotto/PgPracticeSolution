using System;
using System.Collections.Generic;

namespace wordcount001 {
    /// <summary>
    /// 単語のカウント
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_archive/word-count/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // TODO:速度に問題あり

            var words = Console.ReadLine().Split(' ');
            var r = new Dictionary<string, int>();
            var order = new List<string>();

            foreach (var w in words) {
                if (!order.Contains(w)) order.Add(w);
                r[w] = r.ContainsKey(w) ? r[w] + 1 : 1;
            }
            order.ForEach(o => Console.WriteLine($"{o} {r[o]}"));
        }
    }
}
