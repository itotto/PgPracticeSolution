using System;
using System.Collections.Generic;

namespace primefactorization001 {
    /// <summary>
    /// 素因数分解
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__prime_factorization/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var answer = new List<int>();

            while (true) {
                if (n % 2 == 0) {
                    n /= 2;
                    answer.Add(2);
                } else break;
            }


            var div = 3;
            while (n > 1) {
                if (n % div == 0) {
                    n /= div;
                    answer.Add(div);
                } else {
                    div += 2;
                    //if (div > n) {
                    //    answer.Add(div);
                    //    break;
                    //}
                }
            }

            // 結果を表示
            answer.Sort((x, y) => x - y);
            answer.ForEach(a => Console.WriteLine(a));
        }
    }
}
