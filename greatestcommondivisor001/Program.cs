using System;
using System.Collections.Generic;

namespace greatestcommondivisor001 {
    /// <summary>
    /// 最大公約数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__greatest_common_divisor/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var cnt = Convert.ToInt32(Console.ReadLine());
            var numbers = new Dictionary<int, Dictionary<int, int>>();
            var val = 0;
            for (var i = 0; i < cnt; i++) {
                val = Convert.ToInt32(Console.ReadLine());
                if (!numbers.ContainsKey(val)) {
                    var divisors = CountDivisors(val);
                    numbers.Add(val, divisors);
                }
            }

            var answer = numbers[val];
            var organswer = new Dictionary<int, int>(answer.Count);
            foreach (var a in answer) {
                organswer.Add(a.Key, a.Value);
            }
            foreach (var nums in numbers.Values) {
                foreach (var a in organswer) {
                    if (nums.ContainsKey(a.Key)) {
                        if (a.Value > nums[a.Key]) answer[a.Key] = nums[a.Key];
                    } else {
                        answer[a.Key] = 0;
                    }
                }
            }

            var result = 1;
            foreach (var a in answer) {
                var r = 1;
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
