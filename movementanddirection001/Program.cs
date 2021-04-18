using System;
using System.Collections.Generic;
using System.Linq;

namespace movementanddirection001 {
    /// <summary>
    /// 座標系での移動・方角
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_snake_move_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var conditions = Console.ReadLine().Split(' ');
            var y = Convert.ToInt32(conditions[0]);
            var x = Convert.ToInt32(conditions[1]);
            var n = Convert.ToInt32(conditions[2]);

            // 移動方向を入力
            var actions = new List<KeyValuePair<int, int>>(n);
            Enumerable.Range(1, n).ToList().ForEach(i => {
                var direction = Console.ReadLine();
                switch (direction) {
                    case "N":
                        actions.Add(new KeyValuePair<int, int>(0, -1));
                        break;
                    case "W":
                        actions.Add(new KeyValuePair<int, int>(-1, 0));
                        break;
                    case "S":
                        actions.Add(new KeyValuePair<int, int>(0, 1));
                        break;
                    case "E":
                        actions.Add(new KeyValuePair<int, int>(1, 0));
                        break;
                }
            });

            // 移動＋結果を表示
            foreach (var act in actions) {
                x += act.Key;
                y += act.Value;
                Console.WriteLine($"{y} {x}");
            }
        }
    }
}
