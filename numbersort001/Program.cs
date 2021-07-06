using System;
using System.Collections.Generic;

namespace numbersort001 {
    /// <summary>
    /// 数の並び替え
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/etc/sort-number/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var numbers = new List<int>(n);

            for (var i = 0; i < n; i++) {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            numbers.Sort((x, y) => x - y);
            numbers.ForEach(num => Console.WriteLine(num));
        }
    }
}
