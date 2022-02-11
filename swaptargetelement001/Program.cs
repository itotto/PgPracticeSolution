

using System.Collections.Generic;
/// <summary>
/// 指定要素の入れ替え
/// </summary>
/// <remarks></remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n];

for (var i = 0; i < n; i++) {
    var t = Console.ReadLine();
    if (t == null) continue;
    data[i] = t;
}

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var x = Convert.ToInt32(vals[0]) - 1;
var y = Convert.ToInt32(vals[1]) - 1;

var z = data[y];
data[y] = data[x];
data[x] = z;

for (var i = 0; i < n; i++) {
    Console.WriteLine(data[i]);
}
