using System;

namespace printnumberonly002 {
    /// <summary>
    /// 数字のみの出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_add_4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var numbers = new int[n];
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                numbers[i] = Convert.ToInt32(inputs[1]);
            }


            // 結果の表示
            foreach (var num in numbers) {
                Console.WriteLine(num);
            }
        }
    }
}
