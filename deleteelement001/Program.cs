/// <summary>
/// 指定要素の削除
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__delete/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new string[n];
for(var i = 0; i < n; i++) {
    var t = Console.ReadLine();
    if (string.IsNullOrEmpty(t)) continue;
    data[i] = t;
}

var pos = Convert.ToInt32(Console.ReadLine()) - 1;

for (var i = 0; i < n; i++) {
    if (i != pos) Console.WriteLine(data[i]);
}
