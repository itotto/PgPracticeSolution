/// <summary>
/// 文字列の挿入
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step2/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var t = Console.ReadLine();
var n = Convert.ToInt32(Console.ReadLine());

if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

// 結果の表示
Console.WriteLine(s.Insert(n - 1, t));
