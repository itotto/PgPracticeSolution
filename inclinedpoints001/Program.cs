/// <summary>
/// 傾斜配点
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exam/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var weightsArray = Console.ReadLine()?.Split(' ');
if (weightsArray == null) return;
var weights = new int[weightsArray.Length];
for (var i = 0; i < weights.Length; i++) {
    weights[i] = Convert.ToInt32(weightsArray[i]);
}

var maxPoint = 0;

for (var i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    var points = 0;
    for (var j = 0; j < weights.Length; j++) {
        points += (Convert.ToInt32(vals[j]) * weights[j]);
    }
    if (maxPoint < points) maxPoint = points;
}

// 結果の表示
Console.WriteLine(maxPoint);
