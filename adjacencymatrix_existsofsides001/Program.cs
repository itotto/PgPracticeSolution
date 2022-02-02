using System.Text;
/// <summary>
/// 隣接行列の入力・辺の存在判定
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/graph_input_problems/graph_input_problems__adjacency_matrix_boss/edit?language_uid=c-sharp</remarks>


var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var q = Convert.ToInt32(vals[1]);

// 行列を読み込み
var data = new int[n, n];
for (var i = 0; i < n; i++) {
    var line = Console.ReadLine()?.Split(' ');
    if (line == null) continue;
    for(var j = 0; j < line.Length; j++) {
        data[j, i] = Convert.ToInt32(line[j]);
    }
}

var r = new StringBuilder();

for (var i = 0; i < q; i++) {
    var vertexes = Console.ReadLine()?.Split(' ');
    if (vertexes == null) return;
    var a = Convert.ToInt32(vertexes[0]) - 1;
    var b = Convert.ToInt32(vertexes[1]) - 1;
    r.AppendLine($"{data[a, b]}");
}

// 結果の表示
Console.WriteLine(r.ToString());
