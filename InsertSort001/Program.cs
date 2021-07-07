using System;

namespace InsertSort001 {
    /// <summary>
    /// 挿入ソート
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sort_naive/sort_naive__insertion?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
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
                for (var j = 0; j < i; j++) {
                    if (targetValue < sortedArray[j]) {
                        pos = j;
                        break;
                    }
                }

                // 一番大きかったら並べ替えない
                if (pos != -1) {
                    for (var j = i; j > pos; j--) {
                        sortedArray[j] = sortedArray[j - 1];
                    }
                    sortedArray[pos] = targetValue;
                }

                // 結果を表示
                for (var x = 0; x < sortedArray.Length; x++) {
                    Console.Write($"{(x != 0 ? " " : string.Empty)}{sortedArray[x]}");
                }
                Console.WriteLine();
            }
        }
    }
}
