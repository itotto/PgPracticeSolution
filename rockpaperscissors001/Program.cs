using System;
using System.Collections.Generic;

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
            var patterns = Console.ReadLine();

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

        static Dictionary<string, List<string>> _history = new Dictionary<string, List<string>>();

        /// <summary>
        /// じゃんけんを出すパターンを検索
        /// </summary>
        /// <param name="currentKey"></param>
        /// <param name="sumV"></param>
        /// <param name="rest"></param>
        /// <param name="targetValue"></param>
        static List<string> Exec(int sumV, int rest, int targetValue) {

            //** 既に計算済みの結果があればそれを返す(高速化の工夫) **//
            var key = $"{sumV}-{rest}";
            if (_history.ContainsKey(key)) return _history[key];

            var r = new List<string>();

            //** 残りの数値がありえる数字かどうか(高速化の工夫) **//
            var lackV = targetValue - sumV;
            if (2 > lackV || (rest * 5) < lackV) return r;


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

            // 今回の処理結果を保存しておく
            _history.Add(key, r);

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
