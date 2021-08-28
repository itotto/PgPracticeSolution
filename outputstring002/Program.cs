using System;

namespace outputstring002 {
    /// <summary>
    /// 文字列の出力
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/tic_tac_toe_0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int LINECOUNT = 5;
            var lines = new string[LINECOUNT];
            for (var i = 0; i < LINECOUNT; i++) {
                lines[i] = Console.ReadLine();
            }

            for (var i = 0; i < LINECOUNT; i++) {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
