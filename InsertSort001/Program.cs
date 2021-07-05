using System;
using System.Collections.Generic;

namespace InsertSort001 {
    /// <summary>
    /// 挿入ソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sort_naive/sort_naive__insertion?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            Action<int[]> previewArray = (ar) => {
                for (var x = 0; x < ar.Length; x++) {
                    Console.Write($"{(x != 0 ? " " : string.Empty)}{ar[x]}");
                }
                Console.WriteLine();
            };

            var n = Convert.ToInt32(Console.ReadLine());

            // データを取り込む
            var sortedArray = new int[n];
            var data = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++) {
                sortedArray[i] = Convert.ToInt32(data[i]);
            }

            // 並び替え
            for (var i = 1; i < n; i++) {
                var targetValue = sortedArray[i];
                var pos = -1;
                for (var j = 0; j < n; j++) {
                    if (targetValue < sortedArray[j]) {
                        pos = j;
                        break;
                    }
                }

                // 一番大きかったら一番後ろに並べる
                if (pos == -1) pos = n - 1;

                // 並べ替える必要がなければそのまま
                if (pos != i) {
                    for (var j = i; i < n; j++) {

                    }
                }

                // 結果を表示
                previewArray(sortedArray);
            }

        }
    }
}
