using System;

namespace arraysort001 {
    /// <summary>
    /// 配列のソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_add_3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 値
            var numbers = new int[]{ 1, 3, 5, 6, 3, 2, 5, 23, 2 };

            for (var i = 0; i < numbers.Length - 1; i++) {
                for (var j = numbers.Length - 1; j >= i + 1; j--) {
                    if (numbers[j] < numbers[j - 1]) {
                        var tmp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = tmp;
                    }
                }
            }

            // 結果を出力
            for (var i = 0; i < numbers.Length; i++) Console.WriteLine(numbers[i]);
        }
    }
}
