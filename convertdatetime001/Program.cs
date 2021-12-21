/// <summary>
/// 日時データの変換その１
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step2/edit?language_uid=c-sharp</remarks>

var dtstr = Console.ReadLine()?.Split('/');
if (dtstr == null) return;

Console.WriteLine(dtstr[0]);
Console.WriteLine(dtstr[1]);
Console.WriteLine(dtstr[2]);
Console.WriteLine($"{dtstr[3].Split(':')[0]:00}");
Console.WriteLine($"{dtstr[3].Split(':')[1]:00}");
