using System.Text;
/// <summary>
/// 指定要素の検索 (query)
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__multi_search/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var q = Convert.ToInt32(vals[1]);

var data = new int[n];
for (int i = 0; i < n; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

// 並び替える
Array.Sort(data);

var result = new StringBuilder();

for (int i = 0; i < q; i++) {
    var targetVal = Convert.ToInt32(Console.ReadLine());
    var r = false;

    var start = 0;
    var end = data.Length - 1;

    if (data[start] == targetVal ||
        data[end] == targetVal) {
        r = true;
    } else {
        while (true) {
            var pos = (end + start) / 2;
            var arrayVal = data[pos];
            if (arrayVal == targetVal) {
                r = true;
                break;
            } else {
                if (arrayVal > targetVal) end = pos - 1;
                else start = pos + 1;
            }
            if (start > end) break;
        }
    }
    result.AppendLine($"{(r ? "YES" : "NO")}");
}

// 結果の表示
Console.WriteLine(result.ToString());
