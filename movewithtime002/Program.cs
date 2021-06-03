using System;
using System.Collections.Generic;

namespace movewithtime002 {
    /// <summary>
    /// へび
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_mapmove_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // キーを取得
            Func<int, int, string> gKey = (v1, v2) => $"{v1}-{v2}";

            // 壁
            const char WALL = '#';

            const char OCCUPATION = '*';

            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var current_Y = Convert.ToInt32(conditions[2]);
            var current_X = Convert.ToInt32(conditions[3]);
            var n = Convert.ToInt32(conditions[4]);

            // 盤面情報を取得
            var boardInfo = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) boardInfo[i, j] = line[j];
            }

            // 移動方向と距離を入力
            var moves = new Dictionary<int, MoveDirection>(n);
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                moves.Add(
                    Convert.ToInt32(inputs[0]),
                    inputs[1] == "L" ? MoveDirection.Left : MoveDirection.Right
                );
            }

            // 回答用変数を初期化
            var result = new char[height, width];
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) result[i, j] = boardInfo[i, j];
            }

            // 移動＋結果を表示
            var direction = Direction.North;
            var move = new AddPoint(0, -1); // 北に進む
            var history = new Dictionary<string, bool>();
            history.Add(gKey(current_Y, current_X), true);
            result[current_Y, current_X] = OCCUPATION;
            for (var time = 0; time < 100; time++) {
                if (moves.ContainsKey(time)) {
                    move = GetAddPoint(ref direction, moves[time]);
                }
                var next_Y = current_Y + move.Y;
                var next_X = current_X + move.X;

                if ((next_Y < 0 || height <= next_Y) ||
                    (next_X < 0 || width <= next_X) ||
                    (boardInfo[next_Y, next_X] == WALL) ||
                    history.ContainsKey(gKey(next_Y, next_X))) {
                    break;
                }

                // 座標を表示
                result[next_Y, next_X] = OCCUPATION;
                history.Add(gKey(next_Y, next_X), true);

                // いまの位置にする
                current_Y = next_Y;
                current_X = next_X;
            }

            // 回答を表示
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) Console.Write(result[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 移動する座標差分
        /// </summary>
        /// <param name="d">向いている方向(呼出し後は移動後の向きに変わる)</param>
        /// <param name="m">移動する方向</param>
        /// <returns></returns>
        static AddPoint GetAddPoint(ref Direction d, MoveDirection m) {
            switch (d) {
                case Direction.North:
                    d = m == MoveDirection.Left ? Direction.West : Direction.East;
                    return new AddPoint(m == MoveDirection.Left ? -1 : 1, 0);
                case Direction.West:
                    d = m == MoveDirection.Left ? Direction.South : Direction.North;
                    return new AddPoint(0, m == MoveDirection.Left ? 1 : -1);
                case Direction.South:
                    d = m == MoveDirection.Left ? Direction.East : Direction.West;
                    return new AddPoint(m == MoveDirection.Left ? 1 : -1, 0);
                case Direction.East:
                    d = m == MoveDirection.Left ? Direction.North : Direction.South;
                    return new AddPoint(0, m == MoveDirection.Left ? -1 : 1);
            }
            throw new ApplicationException("impossible");
        }

        /// <summary>
        /// 向き
        /// </summary>
        enum Direction {
            /// <summary>
            /// 北
            /// </summary>
            North,

            /// <summary>
            /// 西
            /// </summary>
            West,

            /// <summary>
            /// 南
            /// </summary>
            South,

            /// <summary>
            /// 東
            /// </summary>
            East,
        }

        /// <summary>
        /// 進む方向
        /// </summary>
        enum MoveDirection {
            /// <summary>
            /// 左
            /// </summary>
            Left,

            /// <summary>
            /// 右
            /// </summary>
            Right,
        }

        /// <summary>
        /// 移動座標情報を格納する構造体クラス
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
