/// <summary>
/// 文字列の反転
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step10/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

for(var i = s.Length - 1; i >= 0; i--) {
    Console.Write(s[i]);
}
Console.WriteLine();
