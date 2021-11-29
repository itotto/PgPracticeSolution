/// <summary>
/// 指定要素があるかの判定
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exist?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine().Split(' ');
var n = Convert.ToInt32(inputs[0]);
var k = Convert.ToInt32(inputs[1]);

var r = false;

for (int i = 0; i < n; i++) {
    var a = Convert.ToInt32(Console.ReadLine());
    if (a == k) r = true;
}


// 結果の表示
Console.WriteLine(r ? "Yes" : "No");
