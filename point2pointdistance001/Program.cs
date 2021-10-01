using System;
using System.Collections.Generic;

namespace point2pointdistance001 {
    /// <summary>
    /// 点と点の距離
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step4/edit?language_uid=c-sharp</remarks>
    class Program {

        // System.Drawing.Pointの代わり
        class Point {
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public Point(int x, int y) { X = x; Y = y; }

            public int X { get; set; }

            public int Y { get; set; }
        }

        static void Main() {
            // マンハッタン距離を計算
            //int manhattan_distance(Point p1, Point p2) => Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);
            Func<Point, Point, int> manhattan_distance = (p1, p2) => Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);

            var n = Convert.ToInt32(Console.ReadLine());

            // 入力を格納
            var points = new List<Point>(n);
            for (var i = 0; i < n; i++) {
                var pos = Console.ReadLine().Split(' ');
                points.Add(new Point(Convert.ToInt32(pos[0]), Convert.ToInt32(pos[1])));
            }

            // 閾値となる距離
            var threshold_d = Convert.ToInt32(Console.ReadLine());

            var cnt = 0;

            // 基準点
            var targetP = points[points.Count - 1];

            points.ForEach(p => {
                var d = manhattan_distance(p, targetP);
                if (d <= threshold_d) cnt++;
            });

            // 結果の表示
            Console.WriteLine(cnt);
        }
    }
}
