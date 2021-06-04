using System;
using System.Collections.Generic;

namespace minimumnumber001 {
    /// <summary>
    /// 一番小さい値
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/min_num/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var r = new List<int>();
            for (var i = 0; i < 5; i++) {
                r.Add(Convert.ToInt32(Console.ReadLine()));
            }
            r.Sort((x, y) => x - y);
            Console.WriteLine(r[0]);
        }
    }
}
