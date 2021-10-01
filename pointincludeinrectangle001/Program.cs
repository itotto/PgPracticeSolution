using System;
using System.Collections.Generic;

namespace pointincludeinrectangle001 {
    /// <summary>
    /// 長方形に含まれる点
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step5/edit?language_uid=c-sharp</remarks>
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
            var n = Convert.ToInt32(Console.ReadLine());

            // 入力を格納
            var points = new List<Point>(n);
            for (var i = 0; i < n; i++) {
                var pos = Console.ReadLine().Split(' ');
                points.Add(new Point(Convert.ToInt32(pos[0]), Convert.ToInt32(pos[1])));
            }

            // Xの範囲を指定
            var xRange = Console.ReadLine().Split(' ');
            var x_min = Convert.ToInt32(xRange[0]);
            var x_max = Convert.ToInt32(xRange[1]);

            // Yの範囲を指定
            var yRange = Console.ReadLine().Split(' ');
            var y_min = Convert.ToInt32(yRange[0]);
            var y_max = Convert.ToInt32(yRange[1]);

            // 数える
            var cnt = 0;
            for (var i = 0; i < n; i++) {
                var p = points[i];
                if (x_min <= p.X && p.X <= x_max && y_min <= p.Y && p.Y <= y_max) cnt++;
            }

            // 結果の表示
            Console.WriteLine(cnt);
        }
    }
}
