using System;

namespace sumcalculation001 {
    /// <summary>
    /// 総和の計算
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/etc/a_rank_calculation_step1?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var a = Convert.ToDecimal(conditions[0]);
            var b = Convert.ToDecimal(conditions[1]);

            Console.WriteLine((a + b) * (b - a + 1) / 2);
        }
    }
}
