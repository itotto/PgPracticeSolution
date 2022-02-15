/// <summary>
/// 重複要素の削除
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__unique/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());
var data = new string[n];
for (int i = 0; i < n; i++) {
    var t = Console.ReadLine();
    if (string.IsNullOrEmpty(t)) continue;
    data[i] = t;
}

var dataCopy = new string[n];
var dataCnt = 0;

for (int i = 0; i < n; i++) {
    var bfound = false;
    for (var j = 0; j < dataCnt; j++) {
        if (data[i] == dataCopy[j]) {
            bfound = true;
            break;
        }
    }

    if (!bfound) {
        dataCopy[dataCnt++] = data[i];
    }
}

// 結果を表示
for (var i = 0; i < dataCnt; i++) Console.WriteLine(dataCopy[i]);

