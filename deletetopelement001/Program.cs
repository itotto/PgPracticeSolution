/// <summary>
/// 先頭の要素の削除
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__single_pop/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n - 1];
for (int i = 0; i < n; i++) {
    var v = Console.ReadLine();
    if (i == 0) continue;
    if (string.IsNullOrEmpty(v)) continue;
    data[i - 1] = v;
}

for (var i = 0; i < data.Length; i++) Console.WriteLine(data[i]);

