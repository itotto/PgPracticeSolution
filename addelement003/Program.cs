/// <summary>
/// 指定の位置への要素の追加
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__single_insertion/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);
var q = Convert.ToInt32(vals[2]);

var data = new int[n + 1];

//while (i <= n) {
var offset = 0;
for (var i = 0; i < n; i++) {
    var v = Convert.ToInt32(Console.ReadLine());
    data[i + offset] = v;
    if (i == k - 1) {
        data[i + 1] = q;
        offset++;
    }
}


// 結果を表示
for (var j = 0; j < n + 1; j++) Console.WriteLine(data[j]);

