using System;
using System.Collections.Generic;

namespace goldbachconjecture001 {
    /// <summary>
    /// ゴールドバッハ予想
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__goldbach_conjecture/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 素数
            var primes = new Dictionary<int, bool> { {2, true }, {3, true }, };

            for (var i = 5; i < n; i += 2) {
                if (IsPrime(i)) primes.Add(i, true);
            }

            var v1 = -1;
            var v2 = -1;
            long v_multiple = -1;

            foreach (var p in primes) {
                var d = n - p.Key;
                if (primes.ContainsKey(d)) {
                    long m = d * (long)p.Key;
                    if (m > v_multiple) {
                        v1 = p.Key;
                        v2 = d;
                        v_multiple = m;
                    }
                }
            }

            // 結果の表示
            Console.WriteLine($"{v1}\r\n{v2}");
        }

        static bool IsPrime(int n) {
            var isPrime = n >= 2;
            if (isPrime) {
                if (n >= 3) {
                    var limit = (long)Math.Sqrt(n) + 1;
                    for (var i = 3; i < limit; i += 2) {
                        if (n % i == 0) {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
