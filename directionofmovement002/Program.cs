using System;

namespace directionofmovement002 {
    /// <summary>
    /// 移動が可能かの判定・方向
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_mapmove_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var current_y = Convert.ToInt32(conditions[2]);
            var current_x = Convert.ToInt32(conditions[3]);
            var direction = conditions[4]; // N or W or S or E
            var side = conditions[5]; // L or R

            // 移動する差分座標を
            var move = GetAddPoint(direction, side);

            // データを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) {
                    boardstatus[i, j] = line[j];
                }
            }

            // 新しい座標に移動
            var x = current_x + move.X;
            var y = current_y + move.Y;

            if ((0 <= x && x <= width - 1) &&
                (0 <= y && y <= height - 1) &&
                (boardstatus[y, x] != '#')) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }

        /// <summary>
        /// 移動分の座標を計算する
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="side"></param>
        /// <returns></returns>
        static AddPoint GetAddPoint(string direction, string side) {
            switch (direction) {
                case "N":
                    return new AddPoint(side == "L" ? -1 : 1, 0);
                case "W":
                    return new AddPoint(0, side == "L" ? 1 : -1);
                case "S":
                    return new AddPoint(side == "L" ? 1 : -1, 0);
                case "E":
                    return new AddPoint(0, side == "L" ? -1 : 1);
            }
            throw new ArgumentException("cannot move!");
        }

        /// <summary>
        /// 移動分の座標を保持するための構造体クラス
        /// </summary>
        class AddPoint {
            /// <summary>
            /// Xの移動分
            /// </summary>
            public int X { get; set; }

            /// <summary>
            /// Yの移動分
            /// </summary>
            public int Y { get; set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public AddPoint(int x, int y) {
                X = x; Y = y;
            }
        }
    }
}
