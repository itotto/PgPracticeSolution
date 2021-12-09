/// <summary>
/// 文字列の連結
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/basic_step7/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());
var list = new List<string>(n);

for (int i = 0; i < n; i++) {
    var line = Console.ReadLine();
    if (line == null) continue;
    list.Add(line);
}

list.ForEach(l => Console.Write(l));
Console.WriteLine();
