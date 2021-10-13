using System;
using System.Collections.Generic;

namespace divisor001 {
    /// <summary>
    /// 約数の個数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__number_of_divisor/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var answer = new Dictionary<int, int>();

            var div = 2;
            while (n > 1) {
                if (n % div == 0) {
                    n /= div;
                    if (answer.ContainsKey(div)) {
                        answer[div]++;
                    } else {
                        answer.Add(div, 1);
                    }
                } else {
                    div += div == 2 ? 1 :2;
                }
            }

            var cnt = 1;
            foreach (var k in answer.Values) {
                cnt *= (k + 1);
            }

            // 結果の表示
            Console.WriteLine(cnt);
        }
    }
}
