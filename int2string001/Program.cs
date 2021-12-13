/// <summary>
/// 数値から文字列への変換
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step5/edit?language_uid=c-sharp</remarks>
var x = Convert.ToInt32(Console.ReadLine());
var y = Convert.ToInt32(Console.ReadLine());
var n = Convert.ToInt32(Console.ReadLine());

// 結果の表示
Console.WriteLine((x + y).ToString()[n - 1]);
