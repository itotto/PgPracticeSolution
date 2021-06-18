using System;
using System.Text;

namespace baseballumpire001 {
    /// <summary>
    /// 野球の審判
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_archive/umpire/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var strike = 0;
            var ball = 0;
            var result = new StringBuilder();
            for (var i = 0; i < n; i++) {
                var r = Console.ReadLine();
                if (r == "strike") strike++;
                else if (r == "ball") ball++;

                if (strike == 3 || ball == 4) {
                    result.AppendLine($"{(r == "strike" ? "out!" : "fourball!")}");

                    strike = 0;
                    ball = 0;
                } else {
                    result.AppendLine($"{r}!");
                }
            }

            // 結果の表示
            Console.WriteLine(result.ToString());
        }
    }
}
