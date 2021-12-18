/// <summary>
/// 文字列の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step9/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var t = Console.ReadLine();
if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

// 結果の表示
Console.WriteLine(s.IndexOf(t) >= 0 ? "YES" : "NO");
