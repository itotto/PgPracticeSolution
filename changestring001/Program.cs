/// <summary>
/// 文字列の書き換え
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step3/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;
var i = Convert.ToInt32(inputs[0]) - 1;
var c = inputs[1][0];

    // 結果の表示
for (var j = 0; j < s?.Length; j++) {
    Console.Write($"{(i == j ? c : s[j])}");
}
Console.WriteLine();
