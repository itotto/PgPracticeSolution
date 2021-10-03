using System;

namespace primalitytest002 {
    /// <summary>
    /// 大きな数の素数判定
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__is_prime_normal/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt64(Console.ReadLine());

            var isPrime = n >= 2;
            if (isPrime) {
                if (n >= 3) {
                    var limit = (long)Math.Sqrt(n) + 1;
                    for (var i = 3; i < limit; i += 2) {
                        if (n % i == 0) {
                            isPrime = false;
                            break;
                        }
                    }
                }
            }

            // 結果の表示
            Console.WriteLine(isPrime ? "YES" : "NO");
        }
    }
}
