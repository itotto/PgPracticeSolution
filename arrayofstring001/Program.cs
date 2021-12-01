/// <summary>
/// 文字列の配列
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__string_boss/edit?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
var h = Convert.ToInt32(inputs?[0]);
var w = Convert.ToInt32(inputs?[1]);
var r = Convert.ToInt32(inputs?[2]);
var c = Convert.ToInt32(inputs?[3]);

var map = new char[h, w];

for (var i = 0; i < h; i++) {
    var line = Console.ReadLine();
    if (line == null) continue;
    for (var j = 0; j < w; j++) {
        map[i, j] = line[j];
    }
}

// 結果の表示
Console.WriteLine(map[r - 1, c - 1] == '#' ? "Yes" : "No");
