/// <summary>
/// アイドルグループ
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__idle_group/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);

var members = new List<string>(100000);
for (var i = 0; i < n; i++) {
    var m = Console.ReadLine();
    if (string.IsNullOrEmpty(m)) continue;
    members.Add(m);
}

for (var i = 0; i < k; i++) {
    var query = Console.ReadLine()?.Split(' ');
    if (query == null || query.Length == 0) continue;

    switch (query.Length) {
        case 1:
            members.Sort((x,y) => x.CompareTo(y));
            members.ForEach(m => Console.WriteLine(m));
            break;
        case 2:
            if (query[0] == "join") members.Add(query[1]);
            else if (query[0] == "leave") {
                var idx = members.FindIndex(0, m => m == query[1]);
                members.RemoveAt(idx);
            }
            break;

        default:
            break;
    }
}

