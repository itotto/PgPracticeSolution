using System;

namespace addormultiplicate001 {
    /// <summary>
    /// 足すか掛けるか
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/total_value_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                var a = Convert.ToInt32(inputs[0]);
                var b = Convert.ToInt32(inputs[1]);

                if (a == b) sum += a * b;
                else sum += a + b;
            }

            // 結果の表示
            Console.WriteLine(sum);
        }
    }
}
