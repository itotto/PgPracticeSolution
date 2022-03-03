using System.Text;
/// <summary>
/// 連想配列(query)
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__map_normal/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);

// データを登録
var data = new Dictionary<int, string>();
for (int i = 0; i < n; i++) {
    var inputs = Console.ReadLine()?.Split(' ');
    if (inputs == null) return;
    data.Add(Convert.ToInt32(inputs[0]), inputs[1]);
}

var r = new StringBuilder();

for (int i = 0; i < k; i++) {
    var inputs = Console.ReadLine()?.Split(' ');
    if (inputs == null) return;

    switch (inputs.Length) {
        case 2:
            var num = Convert.ToInt32(inputs[1]);
            if (inputs[0] == "leave") {
                data.Remove(num);
            } else if (inputs[0] == "call") {
                r.AppendLine(data[num]);
            }
            break;

        case 3:
            data.Add(Convert.ToInt32(inputs[1]), inputs[2]);
            break;
    }
}

// 結果の表示
Console.WriteLine($"{r}");

