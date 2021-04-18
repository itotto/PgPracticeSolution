using System;
using System.Linq;

namespace regularmovement001 {
    /// <summary>
    /// 座標系での規則的な移動
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_move_step4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var x = Convert.ToInt32(conditions[0]);
            var y = Convert.ToInt32(conditions[1]);
            var n = Convert.ToInt32(conditions[2]);

            // 移動する
            var d = Direction.X;
            var turn = 1;
            var rest = turn;
            Enumerable.Range(1, n).ToList().ForEach(i => {
                // 移動する
                switch (d) {
                    case Direction.X:
                        x = turn % 2 == 1 ? x + 1 : x - 1;
                        break;
                    case Direction.Y:
                        y = turn % 2 == 1 ? y + 1 : y - 1;
                        break;
                }

                if (--rest <= 0) {
                    switch (d) {
                        case Direction.X:
                            d = Direction.Y;
                            break;
                        case Direction.Y:
                            d = Direction.X;
                            turn++;
                            break;
                    }
                    rest = turn;
                }
            });

            // 結果を表示
            Console.WriteLine($"{x} {y}");
        }

        // 向き
        enum Direction {
            X,
            Y,
        }

    }
}
