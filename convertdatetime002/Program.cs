/// <summary>
/// 日時データの変換その２
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step3/edit?language_uid=c-sharp</remarks>

var datetimeStr = Console.ReadLine()?.Split(' ');
if (datetimeStr == null || datetimeStr.Length != 2) return;

var dateStr = datetimeStr[0].Split('/');
if (dateStr == null || dateStr.Length != 3) return;

var tmStrs = datetimeStr[1].Split(':');
if (tmStrs == null || tmStrs.Length != 2) return;

Console.WriteLine(dateStr[0]);
Console.WriteLine($"{dateStr[1]:00}");
Console.WriteLine($"{dateStr[2]:00}");
Console.WriteLine($"{tmStrs[0]:00}");
Console.WriteLine($"{tmStrs[1]:00}");
