using System;

namespace sumofinteger_more5_001 {
    /// <summary>
    /// 5以上の整数の合計
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/5_or_more_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int THRESHOLD_VALUE = 5;
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (var i = 0; i < n; i++) {
                var v = Convert.ToInt32(Console.ReadLine());
                if (v >= THRESHOLD_VALUE) sum += v;
            }

            // 結果の表示
            Console.WriteLine(sum);
        }
    }
}
