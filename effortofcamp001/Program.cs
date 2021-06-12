using System;
using System.Collections.Generic;

namespace effortofcamp001 {
    /// <summary>
    /// 陣取りの手間
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_camp_step4/edit?language_uid=c-sharp</remarks>
    class Program {
        // 座標情報
        static char[,] _areas = null;

        // 処理対象の座標
        static Queue<Pos> _targets = new Queue<Pos>();

        // 自分の領地
        const char MYAREA = '*';

        // 未占拠の領地
        const char NOT_OCCUPIED = '.';

        static void Main() {

            // 初期情報
            var sizeInfo = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(sizeInfo[0]);
            var width = Convert.ToInt32(sizeInfo[1]);

            // 移動先
            _areas = new char[height, width];

            // 盤面の情報を取得
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                var found = line.IndexOf('*') >= 0;
                for (var j = 0; j < width; j++) {
                    _areas[i, j] = line[j];
                    if (found && line[j] == MYAREA) {
                        _areas[i, j] = '0';
                        _targets.Enqueue(new Pos { X = j, Y = i, Order = 1 });
                        found = false;
                    }
                }
            }

            var cnt = 1;
            while (true) {
                var next = GetNext();
                if (next == null) break;

                var current_Y = next.Y;
                var current_X = next.X;
                var order = next.Order;


                //陣地を制圧する
                // 上
                Occupation(current_Y - 1, current_X, height, width, order);

                // 左
                Occupation(current_Y, current_X - 1, height, width, order);

                // 下
                Occupation(current_Y + 1, current_X, height, width, order);

                // 右
                Occupation(current_Y, current_X + 1, height, width, order);

                cnt++;
            }

            // 結果を表示
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) Console.Write(_areas[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 陣取り処理
        /// </summary>
        /// <param name="next_Y"></param>
        /// <param name="next_X"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="order"></param>
        static void Occupation(int next_Y, int next_X, int height, int width, int order) {
            // 範囲内にある場合のみ
            if ((0 <= next_X && next_X < width) &&
                (0 <= next_Y && next_Y < height)) {
                // .の場合
                if (_areas[next_Y, next_X] == NOT_OCCUPIED) {
                    _areas[next_Y, next_X] = (char)(order + 0x30);
                    //_areas[next_Y, next_X] = MYAREA;
                    _targets.Enqueue(new Pos { Y = next_Y, X = next_X, Order = order + 1 });
                }
            }
        }

        /// <summary>
        /// 次の処理をする情報を取得
        /// </summary>
        /// <returns></returns>
        static Pos GetNext() => _targets.Count > 0 ? _targets.Dequeue() : null;

        class Pos {
            public int X { get; set; }
            public int Y { get; set; }
            public int Order { get; set; }
        }
    }
}
