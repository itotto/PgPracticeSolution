using System;

namespace diffrenceofint001 {
    /// <summary>
    /// 整数値の差
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/restore_command_step0?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(inputs[0]);
            var b = Convert.ToInt32(inputs[1]);

            // 結果の表示
            Console.WriteLine(b - a);
        }
    }
}
