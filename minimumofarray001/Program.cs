/// <summary>
/// 配列の最小値
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__min?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var list = new List<int>(n);
for (int i = 0; i < n; i++) {
    list.Add(Convert.ToInt32(Console.ReadLine()));
}

list.Sort((x, y) => x - y);

// 結果の表示
Console.WriteLine(list[0]);
