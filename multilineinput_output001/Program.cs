using System;
using System.Text;

namespace multilineinput_output001 {
    /// <summary>
    /// 複数行の入力と出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/5_or_more_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var r = new StringBuilder();
            for (var i = 0; i < n; i++) r.AppendLine(Console.ReadLine());

            // 結果の表示
            Console.WriteLine(r.ToString());
        }
    }
}
