using System.Text;
/// <summary>
/// エスカレーター
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step5/edit?language_uid=c-sharp</remarks>

var v = Console.ReadLine()?.Split(' ');
if (v == null) return;
var n  = Convert.ToInt32(v[0]);
var k = Convert.ToInt32(v[1]);


var timings = Console.ReadLine()?.Split(' ');
if (timings == null) return;

var startTimings = new Dictionary<int, int>();

foreach (var ts in timings) {
    var t = Convert.ToInt32(ts);
    if (startTimings.ContainsKey(t)) startTimings[t]++;
    else startTimings.Add(t, 1);
}

var r = new StringBuilder();
var cnt = 0;
var time = 1;

var q = new Queue<bool>();

while (n > 0) {
    if (startTimings.ContainsKey(time)) {
        cnt += startTimings[time];
        n--;
        r.AppendLine(cnt.ToString());
        q.Enqueue(true);
    }else {
        q.Enqueue(false);
    }

    // k回前に追加した部分を終わり
    if (q.Count == k) {
        // 誰か乗ってたら人数を減らす
        if (q.Dequeue()) cnt--;
    }

    time++;
}

// 結果の表示
Console.WriteLine(r.ToString());

