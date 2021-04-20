﻿using System;
using System.Collections.Generic;

namespace movemultipletimes001 {
    /// <summary>
    /// 移動が可能かの判定・複数回の移動
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_mapmove_step3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var current_y = Convert.ToInt32(conditions[2]);
            var current_x = Convert.ToInt32(conditions[3]);
            var n = Convert.ToInt32(conditions[4]);

            // データを取得
            var boardstatus = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < width; j++) {
                    boardstatus[i, j] = line[j];
                }
            }

            // 移動方向を入力
            var moves = new List<MoveDirection>(n);
            for (var i = 0; i < n; i++) {
                moves.Add(Console.ReadLine() == "L" ? MoveDirection.Left : MoveDirection.Right);
            }

            var direction = Direction.North;

            // 移動＋結果を表示
            foreach (var m in moves) {
                var addP = GetAddPoint(ref direction, m);
                current_x += addP.X;
                current_y += addP.Y;
                if ((0 <= current_x && current_x <= width - 1) &&
                    (0 <= current_y && current_y <= height - 1) &&
                    (boardstatus[current_y, current_x] != '#')) {
                    Console.WriteLine($"{current_y} {current_x}");
                } else {
                    Console.WriteLine("Stop");
                    break;
                }
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
