using System;

namespace movementandorientation001 {
    /// <summary>
    /// 座標系での移動・向き 
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_move_step3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var y = Convert.ToInt32(conditions[0]);
            var x = Convert.ToInt32(conditions[1]);
            var direction = conditions[2];

            // 移動する方向
            var d = Console.ReadLine();

            switch (direction) {
                case "N":
                    x = (d == "L") ? x - 1 : x + 1;
                    break;
                case "W":
                    y = (d == "L") ? y + 1 : y - 1;
                    break;
                case "S":
                    x = (d == "L") ? x + 1 : x - 1;
                    break;
                case "E":
                    y = (d == "L") ? y - 1 : y + 1;
                    break;
            }

            // 結果を表示
            Console.WriteLine($"{y} {x}");
        }
    }
}
