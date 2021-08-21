using System;

namespace judgementofduplication001 {
    /// <summary>
    /// 重複の判定
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_add_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var strs = new string[] { "HND", "NRT", "KIX", "NGO", "NGO" };
            var isDuplicated = false;

            for (var i = 0; i < strs.Length - 1; i++) {
                var targetStr = strs[i];
                for (var j = i + 1; j < strs.Length; j++) {
                    if (targetStr == strs[j]) {
                        isDuplicated = true;
                        break;
                    }
                }
            }

            // 結果を表示
            Console.WriteLine(isDuplicated ? "true" : "false");
        }
    }
}
