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

            while (true) {
                if (n % 2 == 0) {
                    n /= 2;
                    if (answer.ContainsKey(2)) {
                        answer[2]++;
                    } else {
                        answer.Add(2, 1);
                    }
                } else break;
            }


            var div = 3;
            while (n > 1) {
                if (n % div == 0) {
                    n /= div;
                    if (answer.ContainsKey(div)) {
                        answer[div]++;
                    } else {
                        answer.Add(div, 1);
                    }
                } else {
                    div += 2;
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
