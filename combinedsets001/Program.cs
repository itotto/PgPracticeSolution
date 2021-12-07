/// <summary>
/// 集合の結合
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__set_boss/edit?language_uid=c-sharp</remarks>
_ = Convert.ToInt32(Console.ReadLine());

var data = new Dictionary<string, bool>();
var list = new List<int>();

var array1 = Console.ReadLine()?.Split(' ');
if (array1 == null) return;
foreach (var a in array1) {
    if (!data.ContainsKey(a)) {
        data.Add(a, true);
        list.Add(Convert.ToInt32(a));
    }
}

var array2 = Console.ReadLine()?.Split(' ');
if (array2 == null) return;
foreach (var a in array2) {
    if (!data.ContainsKey(a)) {
        data.Add(a, true);
        list.Add(Convert.ToInt32(a));
    }
}

list.Sort((x, y) => x - y);
var sep = string.Empty;
foreach (var l in list) {
    Console.Write($"{sep}{l}");
    if (string.IsNullOrEmpty(sep)) sep = " ";
}
Console.WriteLine();
