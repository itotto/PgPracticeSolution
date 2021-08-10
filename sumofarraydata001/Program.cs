using System;

namespace sumofarraydata001 {
    /// <summary>
    /// 配列（リスト）データの足し合わせ
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/5_or_more_4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var sum = 0;
            var array = new int[8] { 4, 0, 5, -1, 3, 10, 6, -8 };

            foreach (var a in array) {
                if (a >= 5) sum += a;
            }

            // 結果の表示
            Console.WriteLine(sum);
        }
    }
}
