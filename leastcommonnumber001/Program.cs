using System;
using System.Collections.Generic;

namespace leastcommonnumber001 {
    /// <summary>
    /// 最小公倍数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__least_common_multiple/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main(string[] args) {
            var cnt = Convert.ToInt32(Console.ReadLine());
            var numbers = new List<Dictionary<int, int>>();
            for (var i = 0; i < cnt; i++) {
                var val = Convert.ToInt32(Console.ReadLine());
                var divisors = CountDivisors(val);
                numbers.Add(divisors);
            }

            var answer = new Dictionary<int, int>();
            foreach (var nums in numbers) {
                foreach (var n in nums) {
                    if (answer.ContainsKey(n.Key)) {
                        if (answer[n.Key] < n.Value) answer[n.Key] = n.Value;
                    } else {
                        answer.Add(n.Key, n.Value);
                    }
                }
            }

            long result = 1;
            foreach (var a in answer) {
                long r = 1;
                for (var i = 0; i < a.Value; i++) {
                    r *= a.Key;
                }
                result *= r;
            }

            // 結果の表示
            Console.WriteLine(result);
        }

        /// <summary>
        /// 整数を素因数とその個数に分解する
        /// </summary>
        /// <param name="n"></param>
        /// <returns>key:素因数, value:個数</returns>
        static Dictionary<int, int> CountDivisors(int n) {
            var result = new Dictionary<int, int>();

            var div = 2;
            while (n > 1) {
                if (n % div == 0) {
                    n /= div;
                    if (result.ContainsKey(div)) {
                        result[div]++;
                    } else {
                        result.Add(div, 1);
                    }
                } else {
                    div += div == 2 ? 1 : 2;
                }
            }

            return result;
        }
    }
}
