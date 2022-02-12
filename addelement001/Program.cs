/// <summary>
/// 末尾への要素の追加
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__push_back/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n + 1];

for(var i = 0; i < n; i++) {
    var t = Console.ReadLine();
    if (string.IsNullOrEmpty(t)) continue;
    data[i] = t;
}

var t2 = Console.ReadLine();
if (string.IsNullOrEmpty(t2)) return;
data[n] = t2;

for (var i = 0; i <= n; i++) {
    Console.WriteLine(data[i]);
}

