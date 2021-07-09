using System;

namespace selectionsort001 {
    /// <summary>
    /// 選択ソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sort_naive/sort_naive__selection?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 操作するデータ
            var current = new short[n];
            var inputs = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                current[i] = Convert.ToInt16(inputs[i]);
            }

            // ソート
            for (var i = 0; i < n - 1; i++) {
                // 最小値を見つける
                var minPos = i;
                for (var j = i + 1; j < n; j++) {
                    if (current[j] < current[minPos]) minPos = j;
                }

                if (minPos != i) {
                    // 値を交換する
                    var tmp = current[i];
                    current[i] = current[minPos];
                    current[minPos] = tmp;
                }

                // 結果を表示
                for (var x = 0; x < current.Length; x++) {
                    Console.Write($"{(x != 0 ? " " : string.Empty)}{current[x]}");
                }
                Console.WriteLine();
            }
        }
    }
}
