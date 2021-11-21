using System;
using System.Collections.Generic;
using System.Linq;

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
            var primes = GetPrimes(MAXNUM);
            primes.Sort((x, y) => x - y);  


            var targetNumbers = new List<int>();
            for (var i = 2; i <= 9999; i++) {
                var x2 = i * i;
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

        //static Dictionary<int, bool> GetPrimes(int n) {
        static List<int> GetPrimes(int n) {
            //var result = new bool[n + 1];
            var result = new Dictionary<int,bool>(n + 1);
            result[0] = false;
            result[1] = false;
            for (var i = 2; i <= n; i++) result[i] = true;

            for (var i = 2; i <= n; i++) {
                if (result[i]) {
                    var idx = 2;
                    while (true) {
                        var x = i * idx;
                        if (x > n) break;
                        result[x] = false;
                        idx++;
                    }
                }
            }
            return result.Where(x => x.Value).Select(x => x.Key).ToList();
        }

    }
}
