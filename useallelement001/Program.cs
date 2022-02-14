/// <summary>
/// 全ての要素を用いた処理
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduce/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new int[n];
for (int i = 0; i < n; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

for (var i = 1; i < n; i++) {
    for (var j = 0; j < i; j++) {
        Console.WriteLine(data[i] * data[j]);
    }
}

