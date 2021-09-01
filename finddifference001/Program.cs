using System;

namespace finddifference001 {
    /// <summary>
    /// 間違い探し
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d2_same_words/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var original = Console.ReadLine();
            Console.WriteLine(original == Console.ReadLine() ? "YES" : "NO");
        }
    }
}
