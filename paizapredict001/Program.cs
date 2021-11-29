using System;
using System.Collections.Generic;

namespace paizapredict001 {
    /// <summary>
    /// paiza 予想
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__paiza_conjecture/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 処理する最大値(10000 - 1)
            const int MAXNUM = 9999;

            // 偶数の素数(1つしかない)
            const int EVEN_PRIME = 2;

            var targetNumbers = new List<int>();
            // 3以上でかつ奇数のみが対象(偶数はgoldbachで証明済みのため除外)
            for (var i = 3; i <= MAXNUM; i += 2) {
                var x2 = i * i;
                if (!IsPrime(x2 - EVEN_PRIME)) targetNumbers.Add(x2);
            }

            // 結果の表示
            if (targetNumbers.Count > 0) {
                targetNumbers.Sort((x, y) => x - y);
                targetNumbers.ForEach(t => Console.WriteLine(t));
            } else {
                Console.WriteLine("paiza's conjecture is correct.");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 素数かどうか判定
        /// </summary>
        /// <param name="n">判定対象の数(3以上)</param>
        /// <returns></returns>
        static bool IsPrime(int n) {
            var limit = (long)Math.Sqrt(n) + 1;
            for (var i = 3; i < limit; i += 2) {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
