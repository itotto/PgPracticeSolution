using System;

namespace getcoordinatefrommap001 {
    /// <summary>
    /// マップからの座標取得
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_move_step1/edit?language_uid=c-sharp</remarks>

    class Program {
        static void Main() {
            const char TARGET_CHAR = '#';
            // 条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);

            // データを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) {
                    boardstatus[i, j] = line[j];
                }
            }

            // 結果の表示
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    if (boardstatus[i, j] == TARGET_CHAR) {
                        Console.WriteLine($"{i} {j}");
                    }
                }
            }
        }
    }
}
