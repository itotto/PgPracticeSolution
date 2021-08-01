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

            // 間隔配列の取得
            var intervals = new int[k];
            var condition2 = Console.ReadLine().Split(' ');
            for (var i = 0; i < k; i++) {
                intervals[i] = Convert.ToInt16(condition2[i]);
            }

            var num_of_moves = 0;

            // ソート
            foreach (var interval in intervals) {
                Console.WriteLine($"interval : {interval}");

                // 0から順番にいけるところまで部分列を操作する
                for (var i = 0; i < n - interval + 1; i++) {
                    Console.WriteLine($"i : {i}");

                    // 部分列を挿入ソートする
                    for (var j = i; j < n; j += interval) {
                        var pos = -1;
                        var min = current[j];
                        var x = j;
                        while (

                        if (pos >= 0) {
                        }
                        // 


                        if (min != current[j])
                    }

                    if (current[i] > current[i + interval]) {
                        var tmp = current[i + interval];
                        current[i + interval] = current[i];
                        current[i] = tmp;
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
