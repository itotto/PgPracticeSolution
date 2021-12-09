/// <summary>
/// 文字の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/basic_step6/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var c = Console.ReadLine();
if (s == null || c == null) return;

// 結果の表示
Console.WriteLine(s.IndexOf(c[0]) + 1);
