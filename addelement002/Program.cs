/// <summary>
/// 指定位置への要素の追加
/// </summary>
/// <remarks></remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n + 1];
for (var i = 0; i < n; i++) {
    var t = Console.ReadLine();
    if (string.IsNullOrEmpty(t)) continue;
    data[i] = t;
}

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var pos = Convert.ToInt32(vals[0]);
var val = vals[1];


// 位置をずらす
for (var i = n - 1; i >= pos; i--) {
    data[i + 1] = data[i];
}
data[pos] = val;

// 結果を表示
for (var j = 0; j <= n; j++) {
    Console.WriteLine(data[j]);
}
