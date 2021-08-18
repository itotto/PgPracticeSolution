using System;

namespace sortascending001 {
    /// <summary>
    /// 昇順ソート出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_asc_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 入力値
            var numbers = new int[n];
            var inputs = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                numbers[i] = Convert.ToInt32(inputs[i]);
            }

            for (var i = 0; i < n - 1; i++) {
                for (var j = n - 1; j >= i + 1; j--) {
                    if (numbers[j] < numbers[j - 1]) {
                        var tmp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = tmp;
                    }
                }
            }

            // 結果を出力
            for (var i = 0; i < n; i++) Console.WriteLine(numbers[i]);
        }
    }
}
