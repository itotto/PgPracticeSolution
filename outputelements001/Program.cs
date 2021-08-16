using System;

namespace outputelements001 {
    /// <summary>
    /// 配列（リスト）の要素の出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/string_count_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var strs = new string[] { "Nara", "Shiga", "Hokkaido", "Chiba" };
            foreach (var s in strs) Console.WriteLine(s);
        }
    }
}
