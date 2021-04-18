using System;
using System.Text;

namespace orientedmovement001 {
    /// <summary>
    /// 座標系での向きの変わる移動
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_move_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 条件入力
            var conditions = Console.ReadLine().Split(' ');
            var x = Convert.ToInt32(conditions[0]);
            var y = Convert.ToInt32(conditions[1]);
            var n = Convert.ToInt32(conditions[2]);

            var direction = Direction.North;

            var r = new StringBuilder();
            for (var i = 0; i < n; i++) {
                var moveDirection = (Console.ReadLine() == "L") ? Movement.Left : Movement.Right;
                var move = GetAddPoint(ref direction, moveDirection);
                x += move.X;
                y += move.Y;
                r.AppendLine($"{x} {y}");
            }

            // 結果を表示
            Console.Write(r.ToString());
        }

        /// <summary>
        /// 移動する座標差分
        /// </summary>
        /// <param name="d">向いている方向(呼出し後は移動後の向きに変わる)</param>
        /// <param name="m">移動する方向</param>
        /// <returns></returns>
        static Point GetAddPoint(ref Direction d, Movement m) {
            switch (d) {
                case Direction.North:
                    d = m == Movement.Left ? Direction.West : Direction.East;
                    return new Point(m == Movement.Left ? -1 : 1, 0);
                case Direction.West:
                    d = m == Movement.Left ? Direction.South : Direction.North;
                    return new Point(0, m == Movement.Left ? 1 : -1);
                case Direction.South:
                    d = m == Movement.Left ? Direction.East : Direction.West;
                    return new Point(m == Movement.Left ? 1 : -1, 0);
                case Direction.East:
                    d = m == Movement.Left ? Direction.North : Direction.South;
                    return new Point(0, m == Movement.Left ? -1 : 1);
            }
            throw new ApplicationException("impossible");
        }

        /// <summary>
        /// 向き
        /// </summary>
        enum Direction {
            North,
            West,
            South,
            East,
        }

        enum Movement {
            Left,
            Right,
        }

        class Point {
            public int X { get; set; }
            public int Y { get; set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public Point(int x, int y) {
                X = x; Y = y;
            }
        }
    }
}
