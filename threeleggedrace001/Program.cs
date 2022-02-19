/// <summary>
/// 二人三脚
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__find_pair/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

// 入力
var talls = new int[n];
for (var i = 0; i < n; i++) {
    talls[i] = Convert.ToInt32(Console.ReadLine());
}

// 並び替え
Array.Sort(talls);

// 比較
var minVal = int.MaxValue;
var minPos = -1;
for (var i = 0; i < n - 1; i++) {
    var diff = talls[i + 1] - talls[i];
    if (diff < minVal) {
        minVal = diff;
        minPos = i;
    }
}

// 結果の表示
Console.WriteLine($"{talls[minPos]}\r\n{talls[minPos + 1]}");
