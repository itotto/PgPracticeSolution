﻿using System;
using System.Collections.Generic;

namespace conditionalmaximum001 {
    /// <summary>
    /// 条件付き最大値
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var inputs = Console.ReadLine().Split(' ');

            var maxThreshold = Convert.ToInt32(Console.ReadLine());

            var answers = new List<int>();

            for (var i = 0; i < inputs.Length; i++) {
                var v = Convert.ToInt32(inputs[i]);
                if (v <= maxThreshold) answers.Add(v);
            }

            // 降順で並び替え
            answers.Sort((x, y) => y - x);

            // 結果の表示
            Console.WriteLine(answers[0]);
        }
    }
}
