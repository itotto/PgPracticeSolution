/// <summary>
/// 部分文字列
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step1/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

var inputs = Console.ReadLine()?.Split(' ');
if (inputs?.Length > 0) {
    var i = Convert.ToInt32(inputs[0]);
    var j = Convert.ToInt32(inputs[1]);

    // 結果の表示
    Console.WriteLine(s.Substring(i - 1, j - i + 1));
}
