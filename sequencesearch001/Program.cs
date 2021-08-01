using System;
using System.Collections.Generic;

namespace sequencesearch001 {
    /// <summary>
    /// 数列の検索
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/restore_command_step3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 初期条件
            var conditions = Console.ReadLine().Split(' ');
            var m = Convert.ToInt32(conditions[0]);
            var n = Convert.ToInt32(conditions[1]);

            // 検索対象の配列を入力
            var sums = new int[m];
            var arrays = new List<int[]>(m);
            for (var i = 0; i < m; i++) {
                var a_input = Console.ReadLine().Split(' ');
                var a = new int[n];
                for (var j = 0; j < n; j++) {
                    a[j] = Convert.ToInt32(a_input[j]);
                    sums[i] += a[j];
                }
                arrays.Add(a);
            }

            // 答え用の配列を初期化
            var x_input = Console.ReadLine().Split(' ');
            var x = new int[n];
            var x_sum = 0;
            for (var i = 0; i < n; i++) {
                x[i] = Convert.ToInt32(x_input[i]);
                x_sum += x[i];
            }

            // 検索＋結果を表示
            for (var i = 0; i < m; i++) {
                // 合計値が違っていればそもそも比べる必要なし
                if (x_sum != sums[i]) continue;

                var isMatched = true;
                for (var j = 0; j < n; j++) {
                    if (arrays[i][j] != x[j]) {
                        isMatched = false;
                        break;
                    }
                }

                if (isMatched) {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
