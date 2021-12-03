/// <summary>
/// 価格の算出
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__dict_step4/edit?language_uid=c-sharp</remarks>
var line = Console.ReadLine()?.Split(' ');
var n = Convert.ToInt32(line?[0]);
var m = Convert.ToInt32(line?[1]);

var items = new Dictionary<string, int>(n);
for(int i = 0; i < n; i++) {
    var itemInfo = Console.ReadLine()?.Split(' ');
    if (itemInfo?[0] == null) continue;
    items.Add(itemInfo[0], Convert.ToInt32(itemInfo?[1]));
}

for (int j = 0; j < m; j++) {
    var item = Console.ReadLine();
    if (item == null) continue;
    Console.WriteLine(items.ContainsKey(item) ? items[item] : -1);
}

