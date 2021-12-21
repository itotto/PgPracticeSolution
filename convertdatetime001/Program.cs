/// <summary>
/// 日時データの変換その１
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step2/edit?language_uid=c-sharp</remarks>

var dtstr = Console.ReadLine()?.Split('/');
if (dtstr == null || dtstr.Length != 4) return;

var tmstrs = dtstr[3].Split(':');
if (tmstrs == null || tmstrs.Length != 2) return;

Console.WriteLine(dtstr[0]);
Console.WriteLine($"{dtstr[1]:00}");
Console.WriteLine($"{dtstr[2]:00}");
Console.WriteLine($"{tmstrs[0]:00}");
Console.WriteLine($"{tmstrs[1]:00}");
