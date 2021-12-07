/// <summary>
/// 重複の判定 2
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__set_step4/edit?language_uid=c-sharp</remarks>
_ = Convert.ToInt32(Console.ReadLine());

// key:数値, value:出現回数
var data = new List<string>();
var inputsdata = Console.ReadLine()?.Split(' ');
if (inputsdata == null) return;

// データを取得
foreach (var d in inputsdata) {
    data.Add(d);
}

for (var i = 1; i < data.Count; i++) {
    var target = data[i];
    var found = false;
    for (var j = 0; j < i; j++) {
        if (data[j] == target) {
            found = true;
            break;
        }
    }

    // 結果の表示
    Console.WriteLine(found ? "Yes" : "No");
}

