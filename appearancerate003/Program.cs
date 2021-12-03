


/// <summary>
/// 文字列の出現率
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__dict_step3/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new Dictionary<string, int>();
var words = new List<string>();

for(var i = 0; i < n; i++) {
    var line = Console.ReadLine();
    if (string.IsNullOrEmpty(line)) continue;
    if (!data.ContainsKey(line)) {
        words.Add(line);
        data[line] = 0;
    }
    data[line]++;
}

// 辞書順に並びなおし
words.Sort((x,y) => x.CompareTo(y));

// 結果を表示
words.ForEach(w => Console.WriteLine($"{w} {data[w]}"));
