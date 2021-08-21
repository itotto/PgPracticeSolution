using System;

namespace duplicationcountarray001 {
    /// <summary>
    /// 配列（リスト）の重複カウント
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/sort_add_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var strs = new string[] { "HND", "NRT", "KIX", "NGO", "NGO", "NGO", "NGO", "NGO" };

            for (var i = 0; i < strs.Length; i++) {
                var targetStr = strs[i];
                var duplicationCount = 0;
                for (var j = 0; j < strs.Length; j++) {
                    if (targetStr == strs[j]) duplicationCount++; // 同じならカウント
                }
                if (duplicationCount > 1) { // 自分自身以外と一致するデータがあれば
                    Console.WriteLine(duplicationCount);
                    break;
                }
            }
        }
    }
}
