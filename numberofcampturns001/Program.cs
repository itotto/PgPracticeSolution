using System;
using System.Collections.Generic;

namespace numberofcampturns001 {
    /// <summary>
    /// 陣取りのターン数
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/a_rank_level_up_problems/a_rank_camp_step5/edit?language_uid=c-sharp</remarks>
    class Program {

        /// <summary>
        /// 陣の情報
        /// </summary>
        static char[,] _areas = null;

        /// <summary>
        /// 処理対象の座標
        /// </summary>
        static Queue<Pos> _targets = null;

        /// <summary>
        /// 特別な処理をする距離
        /// </summary>
        static Dictionary<int, bool> _sp_distances = null;

        // 自分の領地
        const char MYAREA = '*';

        // 未占拠の領地
        const char NOT_OCCUPIED = '.';

        // 障害物
        const char OBSTACLE = '#';

        // 一定の距離にある場合の置換用文字
        const char REPLACE_CHAR = '?';

        static void Main() {
            // 初期条件入力
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var n = Convert.ToInt32(conditions[2]);

            // 盤面の情報を取得
            _areas = new char[height, width];
            _targets = new Queue<Pos>();

            var start_Y = 0;
            var start_X = 0;

            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                var found = line.IndexOf('*') >= 0;
                for (var j = 0; j < width; j++) {
                    _areas[i, j] = line[j];
                    if (found && line[j] == MYAREA) {
                        _areas[i, j] = MYAREA;
                        _targets.Enqueue(new Pos { X = j, Y = i });
                        start_Y = i;
                        start_X = j;
                        found = false;
                    }
                }
            }

            // ?にする距離
            _sp_distances = new Dictionary<int, bool>(n);
            for (var i = 0; i < n; i++) {
                _sp_distances.Add(Convert.ToInt32(Console.ReadLine()), true);
            }

            while (true) {
                var next = GetNext();
                if (next == null) break;

                var current_Y = next.Y;
                var current_X = next.X;


                //陣地を制圧する
                // 上
                Occupation(current_Y - 1, current_X, height, width, start_Y, start_X);

                // 左
                Occupation(current_Y, current_X - 1, height, width, start_Y, start_X);

                // 下
                Occupation(current_Y + 1, current_X, height, width, start_Y, start_X);

                // 右
                Occupation(current_Y, current_X + 1, height, width, start_Y, start_X);

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
        /// <param name="start_Y"></param>
        /// <param name="start_X"></param>
        static void Occupation(int next_Y, int next_X, int height, int width, int start_Y, int start_X) {
            // 範囲内にある場合のみ
            if ((0 <= next_X && next_X < width) &&
                (0 <= next_Y && next_Y < height)) {
                // .の場合
                if (_areas[next_Y, next_X] == NOT_OCCUPIED) {
                    var distance = Math.Abs(start_Y - next_Y) + Math.Abs(start_X - next_X);

                    // ここで経路をチェックして # を迂回できる経路があれば ? 、なければ * のままにする
                    if (_sp_distances.ContainsKey(distance)) {
                        _areas[next_Y, next_X] = ObstacleExists(start_Y, start_X, next_Y, next_X) ? MYAREA : REPLACE_CHAR;
                    } else {
                        _areas[next_Y, next_X] = MYAREA;
                    }
                    _targets.Enqueue(new Pos { Y = next_Y, X = next_X });
                }
            }
        }

        static Dictionary<string, bool> _history = new Dictionary<string, bool>();

        /// <summary>
        /// 経路上に障害物が存在するかどうか
        /// </summary>
        /// <param name="current_Y"></param>
        /// <param name="current_X"></param>
        /// <param name="target_Y"></param>
        /// <param name="target_X"></param>
        /// <returns></returns>
        static bool ObstacleExists(int current_Y, int current_X, int target_Y, int target_X) {
            var key = $"{current_Y}-{current_X}-{target_Y}-{target_X}";
            if (_history.ContainsKey(key)) return _history[key];

            // 自分自身
            var r = _areas[current_Y, current_X] == OBSTACLE;

            if (current_Y != target_Y || current_X != target_X) {
                // Y方向に移動する場合(＋ここまでの経路がすべてOK)
                if (!r && current_Y != target_Y) {
                    r = ObstacleExists(target_Y - current_Y > 0 ? current_Y + 1 : current_Y - 1, current_X, target_Y, target_X);
                }

                // X方向に移動する場合
                if (!r && current_X != target_X) {
                    r = ObstacleExists(target_Y, target_X - current_X > 0 ? current_X + 1 : current_X - 1, target_Y, target_X);
                }
            }

            // キーを登録しておく
            _history.Add(key, r);

            return r;
        }

        /// <summary>
        /// 次の処理をする情報を取得
        /// </summary>
        /// <returns></returns>
        static Pos GetNext() => _targets.Count > 0 ? _targets.Dequeue() : null;

        class Pos {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
