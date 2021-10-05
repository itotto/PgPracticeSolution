using System;

namespace eratosthenessieve001 {
    /// <summary>
    /// エラトステネスの篩
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__eratosthenes/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var isPrime = new bool[n + 1];
            isPrime[0] = false;
            isPrime[1] = false;
            for (var i = 2; i <= n; i++) isPrime[i] = true;

            for (var i = 2; i <= n; i++) {
                if (isPrime[i]) {
                    var idx = 2;
                    while (true) {
                        var x = i * idx;
                        if (x > n) break;
                        isPrime[x] = false;
                        idx++;
                    }
                }
            }

            // 結果の表示
            Console.WriteLine(isPrime[n] ? "YES" : "NO");
        }
    }
}
