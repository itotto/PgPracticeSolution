using System;

namespace _1masscamp002 {
    /// <summary>
    /// 1マスの陣取り2
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_camp_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 自分の領地
            const char MYAREA = '*';

            // 障害物
            const char OBSTACLE = '#';

            // サイズ情報を取得
            var sizeInfo = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(sizeInfo[0]);
            var width = Convert.ToInt32(sizeInfo[1]);

            var current_Y = 0;
            var current_X = 0;

            // 盤面の情報を取得
            var areas = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                var found = line.IndexOf('*') >= 0;
                for (var j = 0; j < width; j++) {
                    areas[i, j] = line[j];
                    if (found && line[j] == MYAREA) {
                        current_Y = i;
                        current_X = j;
                        found = false;
                    }
                }
            }

            //陣地を制圧する
            // 上
            if (current_Y > 0 && areas[current_Y - 1, current_X] != OBSTACLE) {
                areas[current_Y - 1, current_X] = MYAREA;
            }

            // 左
            if (current_X > 0 && areas[current_Y, current_X - 1] != OBSTACLE) {
                areas[current_Y, current_X - 1] = MYAREA;
            }

            // 下
            if (current_Y < height - 1 && areas[current_Y + 1, current_X] != OBSTACLE) {
                areas[current_Y + 1, current_X] = MYAREA;
            }

            // 右
            if (current_X < width - 1 && areas[current_Y, current_X + 1] != OBSTACLE) {
                areas[current_Y, current_X + 1] = MYAREA;
            }

            // 結果を表示
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) Console.Write(areas[i, j]);
                Console.WriteLine();
            }
        }
    }
}
