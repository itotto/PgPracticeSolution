using System;
using System.Collections.Generic;

namespace rockpaperscissors001 {
    /// <summary>
    /// じゃんけんの手の出し方
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/janken/edit?language_uid=c-sharp</remarks>
    class Program {

        // 自分が出した手
        static List<string> _myPatterns = new List<string>();
        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 相手が出す手を取得
            var patterns = Console.ReadLine();

            // じゃんけんを実行
            Exec(string.Empty, 0, n, m);

            // 出した指の本数がmの全部のパターンを試してみる
            var counts = new List<int>();
            _myPatterns.ForEach(my => counts.Add(CountWinning(my, patterns)));

            // 並び替え
            counts.Sort((x, y) => y - x);

            // 結果を表示
            Console.WriteLine(counts[0]);
        }

        /// <summary>
        /// じゃんけんを出すパターンを検索
        /// </summary>
        /// <param name="currentKey"></param>
        /// <param name="sumV"></param>
        /// <param name="rest"></param>
        /// <param name="targetValue"></param>
        static void Exec(string currentKey, int sumV, int rest, int targetValue) {
            // 手を出す
            Action<char> execAction = (c) => {
                var key = $"{currentKey}{c}";

                var addV = 0;
                if (c == 'C') addV = 2;
                else if (c == 'P') addV = 5;

                var sumV_temp = sumV + addV;
                if (sumV_temp == targetValue) { // 同じ場合はここでおしまい(キーは残りをグーで追加して登録する)
                    // 残りを全部Gで埋めたキーを追加
                    _myPatterns.Add($"{key}{new string('G', rest - 1)}");
                } else if (sumV_temp < targetValue) { // 超えなかった場合は次以降を実行する
                    if (rest > 1) {
                        Exec(key, sumV_temp, rest - 1, targetValue);
                    }
                }
            };

            // グーを出す
            execAction('G');

            // チョキを出す
            execAction('C');

            // パーを出す
            execAction('P');
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
