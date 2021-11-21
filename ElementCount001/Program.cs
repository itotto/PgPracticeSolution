/// <summary>
/// 指定の要素のカウント 
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__count?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
var n = Convert.ToInt32(inputs?[0]);
var k = Convert.ToInt32(inputs?[1]);

var cnt = 0;
for (var i = 0; i < n; i++) {
    if (Convert.ToInt32(Console.ReadLine()) == k) cnt++;
}

// 結果の表示
Console.WriteLine(cnt);
