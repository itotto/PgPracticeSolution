using System;

namespace gomoku001 {
    /// <summary>
    /// 五目並べ
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/tic_tac_toe_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int LINECOUNT = 5;
            const int COULUMNCOUNT = 5;
            const char DRAW = 'D';
            var squares = new char[COULUMNCOUNT, LINECOUNT];

            // データを入力
            for (var i = 0; i < LINECOUNT; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < line.Length; j++) {
                    squares[j, i] = line[j];
                }
            }

            // 判定
            var winner = DRAW;

            // 横判定
            for (var i = 0; i < LINECOUNT; i++) {
                var target = squares[0, i];
                if (target == '.') continue;
                var isDeciede = true;
                for (var j = 1; j < squares.GetLength(0); j++) {
                    if (target != squares[j, i]) {
                        isDeciede = false;
                        break;
                    }
                }
                if (isDeciede) {
                    winner = target;
                    break;
                }
            }

            // 縦判定
            if (winner == DRAW) {
                for (var i = 0; i < COULUMNCOUNT; i++) {
                    var target = squares[i, 0];
                    if (target == '.') continue;
                    var isDeciede = true;
                    for (var j = 1; j < squares.GetLength(1); j++) {
                        if (target != squares[i, j]) {
                            isDeciede = false;
                            break;
                        }
                    }
                    if (isDeciede) {
                        winner = target;
                        break;
                    }
                }
            }

            // 斜め判定
            if (winner == DRAW) {
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
            }

            // 結果表示
            Console.WriteLine(winner);
        }
    }
}
