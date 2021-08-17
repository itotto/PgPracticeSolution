using System;
using System.Linq;

namespace outputeachchar002 {
    /// <summary>
    /// １文字ずつ出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/count_string_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() => Console.ReadLine().ToList().ForEach(c => Console.WriteLine(c));
    }
}
