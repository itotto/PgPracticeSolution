using System;
using System.Collections.Generic;

namespace rockpaperscissors001 {
    /// <summary>
    /// じゃんけんの手の出し方
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/janken/edit?language_uid=c-sharp</remarks>
    class Program {

        // 2と5の組み合わせとしてありうる数値
        static Dictionary<int, bool> _possibleValues = new Dictionary<int, bool>();

        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 相手が出す手を取得
            var patterns = Console.ReadLine();

            // 2と5の組み合わせで取れる数値を計算
            CalcPossibleValues(n, m);

            // じゃんけんを実行
            var myPatterns = Exec(0, n, m);

            // 出した指の本数がmの全部のパターンを試してみる
            var counts = new List<int>();
            myPatterns.ForEach(my => counts.Add(CountWinning(my, patterns)));

            // 並び替え
            counts.Sort((x, y) => y - x);

            // 結果を表示
            Console.WriteLine(counts[0]);
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

        /// <summary>
        /// じゃんけんを出すパターンを検索
        /// </summary>
        /// <param name="sumV"></param>
        /// <param name="rest"></param>
        /// <param name="targetValue"></param>
        static List<string> Exec(int sumV, int rest, int targetValue) {
            var r = new List<string>();

            //** 残りの数値がありえる数字かどうか(高速化の工夫) **//
            var lackV = targetValue - sumV;
            if (!_possibleValues.ContainsKey(lackV)) return r;

            // 手を決める
            Action<char> execAction = (c) => {
                var result = new List<string>();

                var addV = 0;
                if (c == 'C') addV = 2;
                else if (c == 'P') addV = 5;

                var sumV_temp = sumV + addV;
                if (sumV_temp == targetValue) { // 同じ場合はここでおしまい(キーは残りをグーで追加して登録する)
                    // 残りを全部Gで埋めたキーを追加
                    result.Add($"{c}{new string('G', rest - 1)}");
                } else if (sumV_temp < targetValue) { // 超えなかった場合は次以降を実行する
                    if (rest > 1) {
                        var list = Exec(sumV_temp, rest - 1, targetValue);
                        if (list.Count > 0) {
                            list.ForEach(l => result.Add($"{c}{l}"));
                        }
                    }
                }
                if (result.Count > 0) r.AddRange(result);
            };

            // グーを出す
            execAction('G');

            // チョキを出す
            execAction('C');

            // パーを出す
            execAction('P');

            return r;
        }

        /// <summary>
        /// 勝っている数を算出
        /// </summary>
        /// <param name="myPatterns"></param>
        /// <param name="yourPatterns"></param>
        /// <returns></returns>
        static int CountWinning(string myPatterns, string yourPatterns) {
            if (myPatterns.Length != yourPatterns.Length) throw new ApplicationException("impossible!");

            var cnt = 0;
            for (var i = 0; i < myPatterns.Length; i++) {
                var your = yourPatterns[i];
                switch (myPatterns[i]) {
                    case 'G':
                        if (your == 'C') cnt++;
                        break;

                    case 'C':
                        if (your == 'P') cnt++;
                        break;

                    case 'P':
                        if (your == 'G') cnt++;
                        break;
                }
            }
            return cnt;
        }
    }
}
