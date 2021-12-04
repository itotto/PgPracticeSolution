/// <summary>
/// 集合の探索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__set_step1/edit?language_uid=c-sharp</remarks>
var data = Console.ReadLine()?.Split(' ');
if (data == null) return;

var line = Console.ReadLine();
if (line == null) return;

var r = false;
foreach (var d in line.Split(' ')) {
    if (d == data[1]) {
        r = true;
        break;
    }
}

// 結果の表示
Console.WriteLine(r ? "Yes" : "No");
