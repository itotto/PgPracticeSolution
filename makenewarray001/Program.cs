/// <summary>
/// 【配列への副作用を伴う操作】条件を満たす要素のみの配列作成
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__filter/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);

var data = new int[n];
var cnt = 0;

for (var i = 0; i < n; i++) {
    var v = Convert.ToInt32(Console.ReadLine());
    if (v >= k) data[cnt++] = v;
}

for (var i = 0; i < cnt; i++) Console.WriteLine(data[i]);

