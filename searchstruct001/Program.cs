

using System.Collections.Generic;
/// <summary>
/// 構造体の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__find/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new Dictionary<int, string>(n);

for (int i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    data.Add(Convert.ToInt32(vals[1]), vals[0]);
}

var targetOld = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(data[targetOld]);

