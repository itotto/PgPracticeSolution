using System;
using System.Collections.Generic;

namespace movementwithtime001 {
    /// <summary>
    /// 時刻に伴う移動
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_mapmove_step6/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            //string GetKey(int v1, int v2) => $"{v1}-{v2}";
            Func<int, int , string> GetKey = (v1, v2) => $"{v1}-{v2}";

            // 壁
            const char WALL = '#';

            // 条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var current_y = Convert.ToInt32(conditions[2]);
            var current_x = Convert.ToInt32(conditions[3]);
            var n = Convert.ToInt32(conditions[4]);

            // 盤面のデータを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) boardstatus[i, j] = line[j];
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

           // 移動＋結果を表示
            var direction = Direction.North;
            var move = new AddPoint(0, -1); // 北に進む
            var history = new Dictionary<string, bool>();
            history.Add(GetKey(current_y, current_x), true);
            for (var time = 0; time < 100; time++) {
                if (moves.ContainsKey(time)) {
                    move = GetAddPoint(ref direction, moves[time]); 
                }
                var next_Y = current_y + move.Y;
                var next_X = current_x + move.X;

                if ((next_Y < 0 || height <= next_Y) ||
                    (next_X < 0 || width <= next_X) ||
                    (boardstatus[next_Y, next_X] == WALL) ||
                    history.ContainsKey(GetKey(next_Y,next_X)) ) {
                    Console.WriteLine("Stop");
                    break;
                }

                // 座標を表示
                Console.WriteLine($"{next_Y} {next_X}");

                // いまの位置にする
                current_y = next_Y;
                current_x = next_X;
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
