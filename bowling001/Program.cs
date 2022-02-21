/// <summary>
/// ボウリング
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__bowling/edit?language_uid=c-sharp</remarks>
const int PIN_COUNT = 4;

// ピンの状態を初期化
var pins = new int[PIN_COUNT, PIN_COUNT];
for (var i = 0; i < PIN_COUNT; i++) {
    for (var j = 0; j < PIN_COUNT; j++) pins[i, j] = 0;
}

var cnt = 0;
var pos = 0;

var basenum = 10;

// ピンの情報を入力
for (var i = 0; i < PIN_COUNT; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;

    for (var j = 0; j < vals.Length; j++) {
        pins[i, j] = Convert.ToInt32(vals[j]);
        if (pins[i, j] == 1) {
            cnt++;
            pos = basenum - j;
        }
    }
    basenum -=  vals.Length;
}

// 結果の表示
Console.WriteLine($"{pos}\r\n{cnt}");

