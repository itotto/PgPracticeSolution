/// <summary>
/// 小文字から大文字への変換
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step7/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;
foreach (var c in s) {
    Console.Write(c > 0x5a ? (char)((int)c - 0x20) : c);
}
Console.WriteLine();
