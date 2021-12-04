/// <summary>
/// 商品の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__dict_boss/edit?language_uid=c-sharp</remarks>

var inputs = Console.ReadLine()?.Split(' ');
var n = Convert.ToInt32(inputs?[0]);
var q = Convert.ToInt32(inputs?[1]);

var products = new Dictionary<string, int>();
for (var i = 1; i <= n; i++) {
    var p = Console.ReadLine();
    if (p == null) continue;
    if (!products.ContainsKey(p)) products.Add(p, i);
}

// 結果を表示
for (var i = 1; i <= q; i++) {
    var s = Console.ReadLine();
    if (s == null) continue;
    Console.WriteLine(products.ContainsKey(s) ? products[s] : -1);
}

