using System;
using System.Text;

namespace stringoutput001 {
    /// <summary>
    /// 文字列の出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/total_value_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var r = new StringBuilder();
            for (var i = 0; i < n; i++) {
                r.AppendLine(Console.ReadLine());
            }
            Console.WriteLine(r.ToString());
        }
    }
}
