/// <summary>
/// 重複の削除
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__set_step2/edit?language_uid=c-sharp</remarks>
_ = Convert.ToInt32(Console.ReadLine());

var org = Console.ReadLine()?.Split(' ').ToList();
if (org == null) return;

var r = new List<int>();
org.ForEach(o => {
    var x = Convert.ToInt32(o);
    if (!r.Contains(x)) r.Add(x);
});

r.Sort((x, y) => x - y);

var sep = string.Empty;
r.ForEach(x => {
    Console.Write($"{sep}{x}");
    if (string.IsNullOrEmpty(sep)) sep = " ";
});
Console.WriteLine();
