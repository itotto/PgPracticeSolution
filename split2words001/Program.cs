/// <summary>
/// 2つの文字列の半角スペース区切りでの分割
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__split_string_step1/edit?language_uid=c-sharp</remarks>
const string TARGETWORDS = "Hello paiza";

var words = TARGETWORDS.Split(' ');

// 結果の表示
foreach (var w in words) Console.WriteLine(w);
