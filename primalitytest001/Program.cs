using System;

namespace primalitytest001 {
    /// <summary>
    /// 素数判定
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__is_prime_easy/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var isPrime = n > 1;
            for (var i = 2; i < n / 2 + 1; i++) {
                if (n % i == 0) {
                    isPrime = false;
                    break;
                }
            }

            // 結果の表示
            Console.WriteLine(isPrime ? "YES" : "NO");
        }
    }
}
