using System;

namespace gomokuline001 {
    /// <summary>
    /// 五目並べ(1行)
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/tic_tac_toe_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int CHARCOUNT = 5;
            const char NOT_SET = '.';
            var line = Console.ReadLine();
            var targetChar = line[0];

            var r = targetChar != NOT_SET;

            if (r) {
                for (var i = 1; i < CHARCOUNT; i++) {
                    if (targetChar != line[i]) {
                        r = false;
                        break;
                    }
                }
            }

            // 結果の表示
            Console.WriteLine(r ? targetChar : 'D');
        }
    }
}
