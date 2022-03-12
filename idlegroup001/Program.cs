
using System.Collections.Generic;
using System.Text;
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


var deletedData = new Dictionary<string, bool>(n);
var r = new StringBuilder();
for (var i = 0; i < k; i++) {
    var query = Console.ReadLine()?.Split(' ');
    if (query == null || query.Length == 0) continue;

    switch (query.Length) {
        case 1:
            if (deletedData.Count > 0) {
                for (var j = members.Count - 1; j >= 0; j--) {
                    if (deletedData.Count == 0) break;
                    var m = members[j];
                    if (deletedData.ContainsKey(m)) {
                        members.RemoveAt(j);
                        deletedData.Remove(m);
                    }
                }
            }

            members.Sort((x, y) => x.CompareTo(y));
            for (var j = 0; j < members.Count; j++) r.AppendLine(members[j]);
            break;
        case 2:
            var name = query[1];
            if (query[0] == "join") {
                members.Add(name);
            } else if (query[0] == "leave") {
                //members.RemoveAt(indexes[name]);
                //members.Remove(name);
                deletedData.Add(name, true);
            }
            break;

        default:
            break;
    }
}
Console.Write(r.ToString());

