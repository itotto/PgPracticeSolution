using System;
using System.Collections.Generic;

namespace linesymmetrypointsymmetry001 {
    /// <summary>
    /// 線対称と点対称
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/b1_symmetry/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var m = Convert.ToInt32(inputs[0]);
            var n = Convert.ToInt32(inputs[1]);

            var squares = new char[m,n];
            for (var i = 0; i < n; i++) {
                var line = Console.ReadLine();
                for (var j = 0; j < m; j++) squares[j, i] = line[j];
            }


            var isLineSymmetry = IsLineSymmetry(squares) ;
            var isPointSymmetry = IsPointSymmetry(squares);

            if (isLineSymmetry || isPointSymmetry) {
                Console.WriteLine($"{(isLineSymmetry ? "line " : "")}{(isPointSymmetry ? "point " : "")}symmetry");
            } else {
                Console.WriteLine("none");
            }
        }

        static bool IsLineSymmetry(char[,] squares) {
            var r = true;



            return r;
        }

        static bool IsPointSymmetry(char[,] squares) {
            var r = true;



            return r;
        }
    }
}
