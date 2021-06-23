using System;
using System.Collections.Generic;

namespace shiritori001 {
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]); // しりとりする人数
            var countOfWords = Convert.ToInt32(conditions[1]); // 単語リストに載ってる単語数
            var countOfRemarks = Convert.ToInt32(conditions[2]); // 発言数

            // 単語を取得
            var words = new Dictionary<string, int>(countOfWords);
            for (var i = 0; i < countOfWords; i++) {
                var w = Console.ReadLine();
                if (words.ContainsKey(w)) words[w]++;
                else words.Add(w, 1);
            }

            // 発言を取得
            var remarks = new List<string>(countOfRemarks);
            for (var i = 0; i < countOfRemarks; i++) remarks.Add(Console.ReadLine());

            // 初期化
            var targets = new Queue<int>(n);
            for (var i = 1; i <= n; i++) targets.Enqueue(i);

            var before = string.Empty;
            // 発言ログを全部確認
            //for (var i = 0; i < remarks.Count; i++) {
            foreach (var r in remarks) {
                if (targets.Count == 0) break;
                var p = targets.Dequeue(); // 発言者の番号
                //var r = remarks[i];

                // 許容されている単語か
                if (words.ContainsKey(r) && words[r] > 0) {
                    words[r]--;
                } else {
                    before = string.Empty;
                    continue;
                }

                // しりとりになっているか(前の人の最後の文字と頭文字が一致しているか)
                if (!string.IsNullOrEmpty(before)) {
                    if (before[before.Length - 1] != r[0]) {
                        before = string.Empty;
                        continue;
                    }
                }

                // zで終わっていないか
                if (r[r.Length - 1] == 'z') {
                    before = string.Empty;
                    continue;
                }

                before = r;
                targets.Enqueue(p);
            }


            // 結果表示用
            var result = new List<int>(targets.Count);

            while (targets.Count > 0) {
                result.Add(targets.Dequeue());
            }

            // 並べる
            result.Sort((x, y) => x - y);

            // 答えを表示
            Console.WriteLine(result.Count);
            result.ForEach(r => Console.WriteLine(r));
        }
    }
}
