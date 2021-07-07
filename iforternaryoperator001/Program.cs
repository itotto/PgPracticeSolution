using System;

namespace iforternaryoperator001 {
    /// <summary>
    /// ifを使いますか？三項演算子を使いますか？
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/etc/ternary/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a > 0 ? "plus" : a.ToString());

            var b = Console.ReadLine();
            Console.WriteLine(b == "hoge" ? "yes" : b);

            var c = Console.ReadLine();
            Console.WriteLine(c.Length == 10 ? "ten" : c);

            var d = Console.ReadLine();
            var dpos = d.IndexOf('x');
            Console.WriteLine(dpos >= 0 ? dpos.ToString() : "nothing");

            var e = Console.ReadLine();
            Console.WriteLine(e.Length ==  5 ? "five" : e[0].ToString());
        }
    }
}
