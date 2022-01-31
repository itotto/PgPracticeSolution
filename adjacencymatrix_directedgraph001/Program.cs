/// <summary>
/// 隣接行列の出力・有向グラフ
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/graph_input_problems/graph_input_problems__adjacency_matrix_step2/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var m = Convert.ToInt32(vals[1]);

// 初期化
var matrix = new int[n, n];
for (var y = 0; y < n; y++) {
    for (var x = 0; x < n; x++) {
        matrix[y, x] = 0;
    }
}

for (var i = 0; i < m; i++) {
    var inputs = Console.ReadLine()?.Split(' ');
    if (inputs == null) return;
    var a = Convert.ToInt32(inputs[0]) - 1; // 配列のインデックスと合わせるために -1 する
    var b = Convert.ToInt32(inputs[1]) - 1; // 配列のインデックスと合わせるために -1 する
    matrix[a, b] = 1;
}


// 結果の表示
for (var y = 0; y < n; y++) {
    for (var x = 0; x < n; x++) {
        Console.Write($"{(x != 0 ? " " : String.Empty)}{matrix[y, x]}");
    }
    Console.WriteLine();
}

