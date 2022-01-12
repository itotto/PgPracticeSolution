/// <summary>
/// 半角スペース区切りの1000個の入力
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__split_input_boss/edit?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;

foreach (var v in inputs) Console.WriteLine(v);
