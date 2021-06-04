using System;

namespace matchletters001 {
    /// <summary>
    /// 文字の一致
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/diff_str/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            Console.WriteLine(a == b ? "OK" : "NG");
        }
    }
}
