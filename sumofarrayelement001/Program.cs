using System;
using System.Linq;

namespace sumofarrayelement001 {
    /// <summary>
    /// 配列（リスト）要素の合計
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/5_or_more_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var array = new int[9] { 1, 3, 5, 6, 3, 2, 5, 23, 2 };

            var sum = 0;
            array.ToList().ForEach(a => sum += a);

            // 結果の表示
            Console.WriteLine(sum);
        }
    }
}
