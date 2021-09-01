using System;

namespace passjudgement001 {
    /// <summary>
    /// 合格判定
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d1_pass_verdict/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() => Console.WriteLine(Convert.ToInt32(Console.ReadLine()) >= 80 ? "pass" : "fail");
    }
}
