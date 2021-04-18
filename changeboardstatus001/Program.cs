using System;

namespace changeboardstatus001 {
    /// <summary>
    /// 盤面の情報変更
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_map_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main(string[] args) {
            var boardinfo = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(boardinfo[0]);
            var width = Convert.ToInt32(boardinfo[1]);
            var n = Convert.ToInt32(boardinfo[2]);

            // データを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) {
                    boardstatus[i, j] = line[j];
                }
            }

            // 変更対象の座標を取得して変更する
            const char NEWCHAR = '#';
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                var y = Convert.ToInt32(inputs[0]);
                var x = Convert.ToInt32(inputs[1]);
                boardstatus[y, x] = NEWCHAR;
            }

            // 盤面を表示する
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    Console.Write(boardstatus[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
