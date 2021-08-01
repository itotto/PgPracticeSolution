using System;

namespace performanceanalysis001 {
    class Program {
        static void Main() {
            // 初期入力
            var condition1 = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(condition1[0]);
            var ep = Convert.ToDouble(condition1[1]);

            var totalEp = 0.0;
            for (var i = 0; i < n; i++) {
                totalEp += Convert.ToDouble(Console.ReadLine());
            }

            var cnt = (int)(totalEp / ep);
            if (totalEp % ep >= 0.1) cnt++;
            Console.WriteLine(cnt);
        }
    }
}
