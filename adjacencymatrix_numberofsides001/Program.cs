/// <summary>
/// 隣接行列の入力・辺の個数
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/graph_input_problems/graph_input_problems__adjacency_matrix_step3/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());

var cnt = 0;

for(var i = 0; i < n; i++) {
    var line = Console.ReadLine()?.Split(' ');
    if (line == null) continue;
    foreach (var c in line) {
        if (c == "1") cnt++;
    }
}


// 結果の表示
Console.WriteLine(cnt / 2);
