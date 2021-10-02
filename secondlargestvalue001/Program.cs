using System;
using System.Collections.Generic;

namespace secondlargestvalue001 {
    /// <summary>
    /// 2番目に大きな値
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_kthmax_step0/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var values = new List<int>();
            var inputs = Console.ReadLine().Split(' ');
            for (var i = 0; i < inputs.Length; i++) {
                values.Add(Convert.ToInt32(inputs[i]));
            }

            // 並び替え
            values.Sort((x, y) => y - x);


            // 結果の表示
            Console.WriteLine(values[1]);
        }
    }
}
