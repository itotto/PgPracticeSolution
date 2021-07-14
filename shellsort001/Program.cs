using System;

namespace shellsort001 {
    /// <summary>
    /// シェルソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sort_efficient/sort_efficient__shell?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // データ配列の数
            var n = Convert.ToInt32(Console.ReadLine());

            // 操作するデータ
            var current = new int[n];
            var condition1 = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                current[i] = Convert.ToInt16(condition1[i]);
            }

            // 間隔配列の数
            var k = Convert.ToInt32(Console.ReadLine());

            // 操作するデータ
            var intervals = new int[k];
            var condition2 = Console.ReadLine().Split(' ');
            for (var i = 0; i < k; i++) {
                intervals[i] = Convert.ToInt16(condition2[i]);
            }

            var num_of_moves = 0;

            // ソート
            foreach (var interval in intervals) {
                Console.WriteLine($"interval : {interval}");
                for (var j = 0; j < n - interval; j++) {
                    Console.WriteLine($"j : {j}");
                    if (current[j] > current[j + interval]) {
                        var tmp = current[j + interval];
                        current[j + interval] = current[j];
                        current[j] = tmp;
                        num_of_moves++;
                    }
                }
                Console.WriteLine(num_of_moves);
                //// 結果を表示
                //for (var x = 0; x < current.Length; x++) {
                //    Console.Write($"{(x != 0 ? " " : string.Empty)}{current[x]}");
                //}
                //Console.WriteLine();
            }
        }
    }
}
