using System;

namespace chineseremaindertheorem001 {
    /// <summary>
    /// 中国剰余定理
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__chinese_remainder_theorem/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var m1 = Convert.ToInt64(inputs[0]);
            var m2 = Convert.ToInt64(inputs[1]);
            var b1 = Convert.ToInt64(inputs[2]);
            var b2 = Convert.ToInt64(inputs[3]);

            long z = -1;

            for (long i = 0; i < m1 * m2; i++) {
                if (i % m1 == b1 && i % m2 == b2) {
                    z = i;
                    break;
                }
            }

            // 結果の表示
            Console.WriteLine(z);
        }
    }
}
