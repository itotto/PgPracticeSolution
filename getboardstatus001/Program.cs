using System;
using System.Text;

namespace getboardstatus001 {
    /// <summary>
    /// 盤面の情報取得
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_map_step1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
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

            var r = new StringBuilder();
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                var y = Convert.ToInt32(inputs[0]);
                var x = Convert.ToInt32(inputs[1]);
                r.AppendLine(boardstatus[y, x].ToString());
            }

            // 結果を表示
            Console.WriteLine(r.ToString());
        }
    }
}
