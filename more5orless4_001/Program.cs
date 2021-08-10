using System;

namespace more5orless4_001 {
    /// <summary>
    /// 5以上か4以下か
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/5_or_more_3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() => Console.WriteLine(Convert.ToInt32(Console.ReadLine()) >= 5 ? "high" : "low" );
    }
}
