/// <summary>
/// 動的配列
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__array_boss/edit?language_uid=c-sharp</remarks>

var inputs = Console.ReadLine()?.Split(' ');
var n = Convert.ToInt32(inputs?[0]);
var q = Convert.ToInt32(inputs?[1]);

// データを入力
var r = new List<int>(n);
var line = Console.ReadLine();
if (line == null) return;
foreach (var a in line .Split(' ')) {
    r.Add(Convert.ToInt32(a));
}

for(int i = 0; i < q; i++) {
    var query = Console.ReadLine()?.Split(' ');
    if (query == null) continue;
    // 追加
    if (query.Length ==  2) {
        r.Add(Convert.ToInt32(query[1]));
    } else {
        switch (query[0]) {
            case "1":
                r.RemoveAt(r.Count - 1);
                break;
            case "2":
                var sep = string.Empty;
                r.ForEach(x => {
                    Console.Write($"{sep}{x}");
                    if (string.IsNullOrEmpty(sep)) sep = " ";
                });
                Console.WriteLine();
                break;
        }
    }
}
