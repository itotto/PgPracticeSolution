using System;

namespace gomokuhorizontal001 {
    /// <summary>
    /// 五目並べ(横)
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/tic_tac_toe_2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int LINECOUNT = 5;
            const char DRAW = 'D';
            var squares = new char[5,5];

            // データを入力
            for (var i = 0; i < LINECOUNT; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < line.Length; j++) {
                    squares[j, i] = line[j];
                }
            }

            // 判定
            var winner = DRAW;
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

            // 結果表示
            Console.WriteLine(winner);
        }
    }
}
