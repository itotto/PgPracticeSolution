/// <summary>
/// ソートと検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__sort_find_single/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var x = Convert.ToInt32(vals[1]);
var p = Convert.ToInt32(vals[2]);

var data = new int[n + 2];
data[0] = p;
data[1] = x;

for (var i = 2; i <= n + 1; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

// 並び替え
Array.Sort(data);

// 結果を表示
Console.WriteLine(Array.BinarySearch(data, p) + 1);

