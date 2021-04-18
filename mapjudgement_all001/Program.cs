using System;

namespace mapjudgement_all001 {
    /// <summary>
    /// マップの判定・縦横
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_map_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const char TARGET_CHAR = '#';

            // 基本情報を取得
            var boardinfo = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(boardinfo[0]);
            var width = Convert.ToInt32(boardinfo[1]);

            // データを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) {
                    boardstatus[i, j] = line[j];
                }
            }

            // 判定 + 結果の表示
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    var judge_l = true; var judge_r = true;
                    var judge_u = true; var judge_d = true;

                    if (j != 0) {
                        judge_l = boardstatus[i, j - 1] == TARGET_CHAR;
                    }

                    if (j != width - 1) {
                        judge_r = boardstatus[i, j + 1] == TARGET_CHAR;
                    }

                    if (i != 0) {
                        judge_u = boardstatus[i - 1, j] == TARGET_CHAR;
                    }

                    if (i != height - 1) {
                        judge_d = boardstatus[i + 1, j] == TARGET_CHAR;
                    }

                    if (judge_l && judge_r && judge_u && judge_d) {
                        Console.WriteLine($"{i} {j}");
                    }
                }
            }
        }
    }
}
