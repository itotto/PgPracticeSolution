using System;
using System.Linq;

namespace splitstr002 {
    /// <summary>
    /// 文字列の分割
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_upper_0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() => Console.ReadLine().Split(' ').ToList().ForEach(c => Console.WriteLine(c));
    }
}
