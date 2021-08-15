using System;

namespace touppercase002 {
    /// <summary>
    /// 指定範囲だけ大文字
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_upper_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var range = Console.ReadLine().Split(' ');
            var start = Convert.ToInt32(range[0]) - 1;
            var end = Convert.ToInt32(range[1]) - 1;

            var str = Console.ReadLine();

            for (var i = 0; i < str.Length; i++) {
                var c = str[i];
                if (c < 0x61 || 0x7a < c)  Console.Write(c);
                //else Console.Write((char)(c - offset));
                else Console.Write((char)(c - ((start <= i && i <= end) ? 32 : 0)));

            }
        }
    }
}
