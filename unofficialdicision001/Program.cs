/// <summary>
/// 内定
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__offer/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);
var m = Convert.ToInt32(vals[2]);

var cnt = 0;
for (var i = 0; i < n; i++) {
    var point = Convert.ToInt32(Console.ReadLine());
    if (point >= k) cnt++;
}

// 結果の表示
Console.WriteLine(cnt - m > 0 ? cnt - m : 0);
