using System;
using System.Collections.Generic;

namespace longtableeelshop001 {
    /// <summary>
    /// 長テーブルのうなぎ屋 
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/long-table/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 座席の状態を初期化
            var currentStatus = new Dictionary<int, bool>(n);
            for (var i = 1; i <= n; i++) currentStatus.Add(i, true);

            var cnt = 0;

            // グループの人数と着席開始番号を入力
            for (var i = 0; i < m; i++) {
                var inputs = Console.ReadLine().Split(' ');
                var memberCount = Convert.ToInt32(inputs[0]);
                var startIndex = Convert.ToInt32(inputs[1]);

                var canSit = true;
                for (var j = startIndex; j < startIndex + memberCount; j++) {
                    if (!currentStatus[j > n ? j % n : j]) {
                        canSit = false;
                        break;
                    }
                }

                if (canSit) {
                    for (var j = startIndex; j < startIndex + memberCount; j++) {
                        currentStatus[j > n ? j % n : j] = false;
                    }
                    cnt += memberCount;
                }
            }

            // 結果を表示
            Console.WriteLine(cnt);
        }
    }
}
