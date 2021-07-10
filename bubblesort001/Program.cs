using System;

namespace bubblesort001 {
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // データを取り込む
            var current = new int[n];
            var data = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                current[i] = Convert.ToInt32(data[i]);
            }

            // ソート
            for (var i = 0; i < n - 1; i++) {
                for (var j = n - 1; j >= i + 1; j--) {
                    if (current[j] < current[j - 1]) {
                        var tmp = current[j];
                        current[j] = current[j - 1];
                        current[j - 1] = tmp;
                    }
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
