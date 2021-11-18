using System;
using System.Collections.Generic;

namespace paizapredict001 {
    /// <summary>
    /// paiza 予想
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__paiza_conjecture/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int MAXNUM = 100000000;

            // 2以上10^8以下の素数を求める
            // 素数
            var primes = new Dictionary<int, bool> { { 2, true }, { 3, true }, };
            for (var i = 5; i < MAXNUM; i += 2) {
                if (IsPrime(i)) primes.Add(i, true);
            }


            var targetNumbers = new List<int>();

            // 結果の表示
            if (targetNumbers.Count == 0) {
                targetNumbers.Sort((x, y) => x - y);
                targetNumbers.ForEach(t => Console.WriteLine(t));
            } else {
                Console.WriteLine("paiza's conjecture is correct.");
            }
            Console.ReadLine();
        }

        static bool IsPrime(int n) {
            var limit = (long)Math.Sqrt(n) + 1;
            for (var i = 3; i < limit; i += 2) {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
