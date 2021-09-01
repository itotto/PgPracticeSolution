using System;

namespace notationofmidnighttime001 {
    /// <summary>
    /// 深夜時間の表記
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d3_night_time/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() => Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 24);
    }
}
