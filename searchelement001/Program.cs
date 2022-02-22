/// <summary>
/// 指定要素の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__single_search/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);

var r = false;

for (int i = 0; i < n; i++) {
    var data = Console.ReadLine();
    if (string.IsNullOrEmpty(data)) continue;
    if (data  == vals[1]) r = true;
}

// 結果の表示
Console.WriteLine(r ? "YES" : "NO");
