using System;
using System.Collections.Generic;

namespace bloodtypedataprocessing001 {
    /// <summary>
    /// ユーザーの血液型のデータ処理 
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/fortune_telling_1/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var data = new Dictionary<string, string>(n);

            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine().Split(' ');
                data.Add(inputs[0], inputs[1]);
            }

            foreach (var d in data) Console.WriteLine($"{d.Key} {d.Value}");
        }
    }
}
