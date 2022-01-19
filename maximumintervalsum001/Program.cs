/// <summary>
/// 最大の区間和
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step2/edit?language_uid=c-sharp</remarks>

var v = Console.ReadLine()?.Split(' ');
if (v == null) return;

var n = Convert.ToInt32(v[0]);
var x = Convert.ToInt32(v[1]);

var dataStrs = Console.ReadLine()?.Split(' ');
if (dataStrs == null) return;

// 対象の配列
var data = new int[dataStrs.Length];
for (int i = 0; i < dataStrs.Length; i++)
    data[i] = Convert.ToInt32(dataStrs[i]);

var max = int.MinValue;
var pos = -1;
var sumlist = new List<int>(n - x + 1);

var needCalc = x == 1;

for (var i = 0; i <= n - x; i++) {
    var sum = 0;
    if (needCalc || i == 0) {
        for (var j = i; j < x + i; j++) {
            sum += data[j];
        }
    } else {
        sum = sumlist[i - 1] - data[i - 1] + data[i + x - 1];
    }
    sumlist.Add(sum);
    if (max < sum) {
        max = sum;
        pos = i;
    }
}

// 結果の表示
Console.WriteLine($"{max} {data[pos]}");
