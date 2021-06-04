using System;

namespace multiplication001 {
    /// <summary>
    /// 掛け算
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/multiplication/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            // 結果の表示
            Console.WriteLine(a * b);
        }
    }
}
