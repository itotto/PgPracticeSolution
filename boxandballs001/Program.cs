/// <summary>
/// 箱とボール
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step6/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

// 値を取得
var data = new List<int>(n);
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
foreach (var v in vals) {
    data.Add(Convert.ToInt32(v));
}

// 箱に積む
var box = new Stack<int>();

data.ForEach(d => {
    var currentV = d;
    while (true) {
        if (box.Count == 0) {
            box.Push(currentV);
            break;
        }

        var lastV = box.Pop();
        if ( currentV != lastV) {
            box.Push(lastV);
            box.Push(currentV);
            break;
        }
        currentV += lastV;
    }
});


var boxCount = box.Count;

// 結果の表示
for (var i = 0; i < boxCount; i++) {
    Console.WriteLine(box.Pop());
}

