using System;
using System.Collections.Generic;
using System.Linq;

namespace rockpaperscissors001 {
    /// <summary>
    /// じゃんけんの手の出し方
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/janken/edit?language_uid=c-sharp</remarks>
    class Program {

        // 2と5の組み合わせとしてありうる数値
        static Dictionary<int, bool> _possibleValues = new Dictionary<int, bool>();

        // 取りうるパターン
        static List<Dictionary<char, int>> _myPatterns = new List<Dictionary<char, int>>();

        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 相手が出す手を取得
            var patterns = Console.ReadLine().ToList();
            var yourPatterns = new Dictionary<char, int> { { 'G', 0 }, { 'C', 0 }, { 'P', 0 }, };
            patterns.ForEach(p => yourPatterns[p]++);

            // 2と5の組み合わせで作れる数値を検索しておく
            CalcPossibleValues(n, m);

            // じゃんけんを実行
            Exec(string.Empty, 0, n, m);

            // 出した指の本数がmの全部のパターンを試してみる
            var counts = new List<int>();
            _myPatterns.ForEach(my => {
                my.Add('G', n - (my['C'] + my['P'])); // グーを足す
                counts.Add(CountWinning(my, yourPatterns));
            });

            // 並び替え
            counts.Sort((x, y) => y - x);

            // 結果を表示
            Console.WriteLine(counts[0]);
        }


        static void Exec(string currentKey, int sumV, int rest, int targetValue) {
            //** 残りの数値がありえる数字かどうか(高速化の工夫) **//
            var lackV = targetValue - sumV;
            if (!_possibleValues.ContainsKey(lackV)) return ;

            Action<char> execAction = (c) => {
                var key = $"{currentKey}{c}";

                var addV = c == 'C' ? 2 : 5;

                var sumV_temp = sumV + (c == 'C' ? 2 : 5);
                if (sumV_temp == targetValue) { // 同じ場合はここでおしまい(キーは残りをグーで追加して登録する)
                    var patterns = new Dictionary<char, int> { { 'C', 0 }, { 'P', 0 }, };
                    key.ToList().ForEach(p => patterns[p]++);
                    _myPatterns.Add(patterns);
                } else if (sumV_temp < targetValue) { // 超えなかった場合は次以降を実行する
                    if (rest > 1) Exec(key, sumV_temp, rest - 1, targetValue);
                }
            };

            // チョキを出す
            execAction('C');

            // パーを出す
            execAction('P');
        }


        static Dictionary<string, List<string>> _history = new Dictionary<string, List<string>>();


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

        /// <summary>
        /// 手の組み合わせでありうる数値を計算
        /// </summary>
        /// <param name="n"></param>
        /// <param name="targetValue"></param>
        static void CalcPossibleValues(int n, int targetValue) {
            // 足したらiになる組み合わせを考える
            for (var i = n - 1; i > 0; i--) { // 
                for (var j = i; j >= 0; j--) { // 
                    var key = 2 * j + 5 * (i - j);
                    if (key > targetValue) break;
                    if (!_possibleValues.ContainsKey(key)) _possibleValues.Add(key, true);
                }
            }
        }
    }
}
