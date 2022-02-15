/// <summary>
/// 配列のサイズの変更
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__resize/edit?language_uid=c-sharp</remarks>
const int DEFVAL = 0;

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var firstSize = Convert.ToInt32(vals[0]);
var realSize = Convert.ToInt32(vals[1]);

var data = new int[firstSize > realSize ? firstSize : realSize];
for(var i = 0; i < data.Length; i++) data[i] = DEFVAL;
for(var i = 0; i < firstSize; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

// 結果の表示
for (var i = 0; i < realSize; i++) Console.WriteLine(data[i]);
