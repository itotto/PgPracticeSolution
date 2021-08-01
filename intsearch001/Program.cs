using System;

namespace intsearch001 {
    /// <summary>
    /// 整数値の検索
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/restore_command_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var a = new int[n];
            var inputs = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                a[i] = Convert.ToInt32(inputs[i]);
            }
            var targetValue = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++) {
                if (a[i] == targetValue) {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
