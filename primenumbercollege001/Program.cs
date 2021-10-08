using System;
using System.Collections.Generic;

namespace primenumbercollege001 {
    /// <summary>
    /// 素数大学
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__is_prime_multi/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            Func<int, bool> isPrime = (num) => {
                if (num <= 2) return num == 2;
                if (num % 2 == 0) return false;
                var limit = (long)Math.Sqrt(num) + 1;
                for (var i = 3; i <= limit; i += 2) {
                    if (num % i == 0) return false;
                }
                return true;
            };

            var cnt = Convert.ToInt32(Console.ReadLine());

            var maxNum = 0;
            // 受験番号を入力
            var numbers = new List<int>(cnt);
            for (var i = 0; i < cnt; i++) {
                var num = Convert.ToInt32(Console.ReadLine());
                if (num > maxNum) maxNum = num;
                numbers.Add(num);
            }

            // 判定して結果を表示
            numbers.ForEach(n => {
                Console.WriteLine(isPrime(n) ? "pass" : "failure");
            });
        }
    }
}
