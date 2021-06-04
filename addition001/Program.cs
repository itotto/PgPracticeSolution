using System;

namespace addition001 {
    /// <summary>
    /// 足し算
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/problem_index?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var inputs = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(inputs[0]);
            var b = Convert.ToInt32(inputs[1]);

            // 結果の表示
            Console.WriteLine(a + b);
        }
    }
}
