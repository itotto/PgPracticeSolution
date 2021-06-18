using System;
using System.Collections.Generic;

namespace lottery001 {
    /// <summary>
    /// 宝くじ
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_archive/lottery/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 当選番号
            var winningnumber = Convert.ToInt32(Console.ReadLine());

            // 購入枚数
            var n = Convert.ToInt32(Console.ReadLine());

            var result = new List<string>(n);
            for (var i = 0; i < n; i++) {
                var current = Convert.ToInt32(Console.ReadLine());
                result.Add(Judge(winningnumber, current));
            }

            // 結果を表示
            result.ForEach(r => Console.WriteLine(r));
        }

        /// <summary>
        /// 判定処理
        /// </summary>
        /// <param name="winningnumber"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        static string Judge(int winningnumber, int current) {
            if (winningnumber == current) {
                return "first";
            } else {
                // 前後賞を判定
                if (winningnumber + 1 == current || winningnumber - 1 == current) {
                    return "adjacent";
                } else if (winningnumber % 10000 == current % 10000) {
                    return "second";
                } else if (winningnumber % 1000 == current % 1000) {
                    return "third";
                } else {
                    return "blank";
                }
            }
        }
    }
}
