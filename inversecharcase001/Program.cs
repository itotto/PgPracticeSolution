/// <summary>
/// 大文字小文字の反転
/// </summary>
/// <remarksa>https://paiza.jp/works/mondai/string_primer/normal_step8/edit?language_uid=c-sharp</remarksa>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;
foreach (var c in s) {
    var ic = (int)c;
    Console.Write((0x41 <= ic && ic <= 0x5A) ? (char)(c + 0x20) : (char)(c - 0x20));
}
Console.WriteLine();

