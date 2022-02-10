/// <summary>
/// 変数の入れ替え
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__excange/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;

// 結果の表示
Console.WriteLine($"{vals[1]} {vals[0]}");
