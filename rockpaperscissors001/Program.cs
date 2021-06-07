using System;
using System.Collections.Generic;
using System.Linq;

namespace rockpaperscissors001 {
    /// <summary>
    /// じゃんけんの手の出し方
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/janken/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 相手が出す手を取得
            var patterns = Console.ReadLine().ToList();
            var yourPatterns = new Dictionary<char, int> { { 'G', 0 }, { 'C', 0 }, { 'P', 0 }, };
            patterns.ForEach(p => yourPatterns[p]++);

            // 2と5の組み合わせで作れる数値を検索する
            var myPatterns = CalcPossibleValues(n, m);

            // 出した指の本数がmの全部のパターンを試してみる
            var counts = new List<int>();
            myPatterns.ForEach(my => {
                my.Add('G', n - (my['C'] + my['P'])); // グーを足す
                counts.Add(CountWinning(my, yourPatterns));
            });

            // 並び替え
            counts.Sort((x, y) => y - x);

            // 結果を表示
            Console.WriteLine(counts.Count == 0 ? 0 : counts[0]);
        }

        /// <summary>
        /// 手の組み合わせでありうる数値を計算
        /// </summary>
        /// <param name="n"></param>
        /// <param name="targetValue"></param>
        static List<Dictionary<char, int>> CalcPossibleValues(int n, int targetValue) {
            var r = new List<Dictionary<char, int>>();
            // 足したらiになる組み合わせを考える
            for (var i = n - 1; i >= 0; i--) { // 
                for (var j = i; j >= 0; j--) { // 
                    var key = 2 * j + 5 * (i - j);
                    if (key == targetValue) {
                        var v = new Dictionary<char, int>();
                        v.Add('C', j);
                        v.Add('P', i - j);
                        r.Add(v);
                    }
                    if (key > targetValue) break;
                }
            }
            return r;
        }

        /// <summary>
        /// 勝っている数を算出
        /// </summary>
        /// <param name="myPatterns"></param>
        /// <param name="yourPatterns"></param>
        /// <returns></returns>
        static int CountWinning(Dictionary<char, int> myPatterns, Dictionary<char, int> yourPatterns) {
            var cnt = 0;

            // 相手：グー、自分：パー
            cnt += Math.Min(yourPatterns['G'], myPatterns['P']);

            // 相手：チョキ、自分：グー
            cnt += Math.Min(yourPatterns['C'], myPatterns['G']);

            // 相手：パー、自分：チョキ
            cnt += Math.Min(yourPatterns['P'], myPatterns['C']);

            return cnt;
        }
    }
}
