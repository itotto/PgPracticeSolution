using System;
using System.Collections.Generic;

namespace useassociativearray001 {
    /// <summary>
    /// 連想配列（辞書）を使う
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var data = new Dictionary<string, string> {
                {"Kyoko", "B" },
                {"Rio", "O" },
                {"Tsubame", "AB" },
                {"KurodaSensei", "A" },
                {"NekoSensei", "A" },
            };

            foreach (var d in data) Console.WriteLine($"{d.Key} {d.Value}");
        }
    }
}
