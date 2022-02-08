/// <summary>
/// 要素の種類数
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__kind/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var cnt = 0;
var data = new string[n];
for (var i = 0; i < n; i++) {
    var s = Console.ReadLine();
    if (string.IsNullOrEmpty(s)) continue;
    var notfound = true;
    for (var j = 0; j < i; j++) {
        if (data[j] == s) {
            notfound = false;
            break;
        }
    }
    if (notfound) cnt++;
    data[i] = s;
}

// 結果の表示
Console.WriteLine(cnt);

