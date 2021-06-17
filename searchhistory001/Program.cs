using System;
using System.Collections.Generic;

namespace searchhistory001 {
    /// <summary>
    /// 検索履歴
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_archive/search_history/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // TODO: List<T>.Contains()は遅いのであとで直す
            var r = new List<string>(n);
            for (var i = 0; i < n; i++) {
                var w = Console.ReadLine();
                if (r.Contains(w)) r.Remove(w);
                r.Add(w);
            }

            if (r.Count > 0) {
                for (var i = r.Count - 1; i >= 0; i--) Console.WriteLine(r[i]);
            }
        }
    }
}
