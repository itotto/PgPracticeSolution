using System;
using System.Collections.Generic;

namespace yamadalikesodd001 {
    /// <summary>
    /// 奇数大好き山田さん
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/c1_odd_number/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var odds = new List<int>(n);
            for (var i = 0; i < n; i++) {
                var num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 1) odds.Add(num);
            }
            odds.Sort((x, y) => x - y);
            odds.ForEach(o => Console.WriteLine(o));
        }
    }
}
