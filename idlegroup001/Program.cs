
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
    members.Add(Console.ReadLine());
}

var deletedData = new Dictionary<string, bool>(n);
var r = new StringBuilder();
for (var i = 0; i < k; i++) {
    var query = Console.ReadLine()?.Split(' ');

    if (query[0] == "handshake") {
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
    } else if (query[0] == "join") {
        members.Add(query[1]);
    } else if (query[0] == "leave") {
        deletedData.Add(query[1], true);
    }
}
Console.Write(r.ToString());

