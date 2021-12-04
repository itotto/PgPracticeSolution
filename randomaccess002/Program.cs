/// <summary>
/// 複数回のランダムアクセス
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__array_step2/edit?language_uid=c-sharp</remarks>

_ = Convert.ToInt32(Console.ReadLine());
var a = Console.ReadLine()?.Split(' ');
if (a == null) return;

_ = Convert.ToInt32(Console.ReadLine());
var line = Console.ReadLine();
if (line == null) return;
foreach (var b in line.Split(' ')) {
    Console.WriteLine(a[Convert.ToInt32(b) - 1]);
}

