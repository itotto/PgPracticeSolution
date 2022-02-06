/// <summary>
/// 指定要素の先頭位置
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__find/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = vals[1];

var data = new string[n];

for (var i = 0; i < n; i++) data[i] = Console.ReadLine();

var pos = -1;

for (var i = 0; i < n; i++) {
    if (data[i] == k) {
        pos = i + 1;
        break;
    }
}


// 結果の表示
Console.WriteLine(pos);

