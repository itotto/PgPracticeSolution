using System;

namespace stringsplit001 {
    /// <summary>
    /// 文字列の分割
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/problem_index?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            foreach (var s in Console.ReadLine().Split(' ')) Console.WriteLine(s);
        }
    }
}
