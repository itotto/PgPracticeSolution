/// <summary>
/// 配列の順序の反転
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reverse/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n];

for (int i = 0; i < n; i++) {
    data[i] = Console.ReadLine();
}

// 結果の表示
for (int j = n - 1; j >= 0; j--) {
    Console.WriteLine(data[j]);
}

