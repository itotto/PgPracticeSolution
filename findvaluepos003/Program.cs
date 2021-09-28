using System;
using System.Collections.Generic;

namespace findvaluepos003 {
    /// <summary>
    /// 指定された値の位置 3
    /// </summary>
    class Program {
        static void Main() {
            // nは使わない
            _ = Convert.ToInt32(Console.ReadLine());

            // 検索される配列
            var values = Console.ReadLine().Split(' ');

            var targetValue = Console.ReadLine();

            // 答え
            var answers = new List<int>();

            for (var i = 0; i < values.Length; i++) {
                if (values[i] == targetValue) answers.Add(i);
            }

            answers.ForEach(a => Console.WriteLine($"{a + 1}"));
        }
    }
}
