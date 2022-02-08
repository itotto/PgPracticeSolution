using System.Text;
/// <summary>
/// 全ての要素に対する操作
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__map/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);

var r = new StringBuilder();

for (var i = 0; i < n; i++) {
    r.AppendLine($"{(Convert.ToInt32(Console.ReadLine()) + k)}");
}

// 結果の表示
Console.WriteLine(r.ToString());
