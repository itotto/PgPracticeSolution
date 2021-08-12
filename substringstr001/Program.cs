using System;

namespace substringstr001 {
    /// <summary>
    /// 文字列を切り取る
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/substring_9/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var start = Convert.ToInt32(inputs[0]);
            var end = Convert.ToInt32(inputs[1]);

            var str = Console.ReadLine();

            Console.WriteLine(str.Substring(start - 1, end - start + 1));
        }
    }
}
