using System;

namespace gomokudiagonal001 {
    /// <summary>
    /// 五目並べ（斜め）
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/tic_tac_toe_4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int LINECOUNT = 5;
            const char DRAW = 'D';
            var squares = new char[5, 5];

            // データを入力
            for (var i = 0; i < LINECOUNT; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < line.Length; j++) {
                    squares[j, i] = line[j];
                }
            }

            // 判定
            var winner = DRAW;

            // ↘方向のチェック
            var target1 = squares[0, 0];
            var isDeciede1 = target1 != '.';
            if (isDeciede1) {
                for (var i = 1; i < LINECOUNT; i++) {
                    if (target1 != squares[i, i]) {
                        isDeciede1 = false;
                        break;
                    }
                }
            }

            if (isDeciede1) {
                winner = target1;
            } else {
                // ↙方向のチェック
                var target2 = squares[0, LINECOUNT - 1];
                var isDeciede2 = target2 != '.';
                if (isDeciede2) {
                    for (var j = 1; j < LINECOUNT; j++) {
                        if (target2 != squares[j, LINECOUNT - j - 1]) {
                            isDeciede2 = false;
                            break;
                        }
                    }
                }
                if (isDeciede2) {
                    winner = target2;
                }
            }
            // 結果表示
            Console.WriteLine(winner);
        }
    }
}
