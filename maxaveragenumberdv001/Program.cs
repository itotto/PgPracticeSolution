using System;
using System.Collections.Generic;

namespace maxaveragenumberdv001 {
    /// <summary>
    /// 日別訪問者数の最大平均区間
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_archive/max_range/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            var accessCounts = new List<int>(n);
            foreach (var access in Console.ReadLine().Split(' ')){
                accessCounts.Add(Convert.ToInt32(access));
            }

            var max = 0;
            var startIndex = -1;
            var cnt = 0;
            for (var i = 0; i <= n - k; i++) {
                //Console.WriteLine(i);
                var sum = 0;
                for (var j = i; j <= i + k - 1; j++) sum += accessCounts[j];

                if (sum > max) {
                    max = sum;
                    startIndex = i;
                    cnt = 1;
                } else if (sum == max) {
                    cnt++;
                }
            }

            // 回答
            Console.WriteLine($"{cnt} {startIndex + 1}");
        }
    }
}
