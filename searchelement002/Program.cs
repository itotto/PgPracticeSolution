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
    var k = Convert.ToInt32(Console.ReadLine());
    var r = false;
    for (var j = 0; j < data.Length; j++) {
        var x = data[j];
        if (x >= k) {
            r = x == k;
            break;
        }
    }
    result.AppendLine($"{(r ? "YES" : "NO")}");
}

// 結果の表示
Console.WriteLine(result.ToString());
