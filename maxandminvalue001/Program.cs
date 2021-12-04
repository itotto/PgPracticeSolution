/// <summary>
/// 最大値と最小値
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__array_step3/edit?language_uid=c-sharp</remarks>
var r = new List<int>(3);

var line = Console.ReadLine();
if (line == null) return;
foreach (var a in line.Split(' ')) {
    r.Add(Convert.ToInt32(a));
}
r.Sort((x,y) => x - y);

// 結果の表示
Console.WriteLine(r[2] - r[0]);
