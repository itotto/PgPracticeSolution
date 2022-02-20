/// <summary>
/// 場所取り
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__line_up/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);
var f = Convert.ToInt32(vals[2]);

var data = new int[k - f];

for (var i = 0; i < k; i++) {
    var x = Console.ReadLine();
    if (string.IsNullOrEmpty(x)) continue;
    if (i >= f) data[i - f] = Convert.ToInt32(x);
}

var cnt = 0;
var pos = new int[n];
for (var i = 0; i < data.Length; i++) {
    var bfound = false;
    for (var j = 0; j < cnt; j++) {
        if (data[i] == pos[j]) {
            bfound = true;
            break;
        }
    }
    if (!bfound) pos[cnt++] = data[i];
}

for (var i = 0; i < cnt; i++) {
    Console.WriteLine(pos[i]);
}
