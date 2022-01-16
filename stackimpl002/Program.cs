using System.Text;
/// <summary>
/// スタック実装編 step 2
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__stack_step2/edit?language_uid=c-sharp</remarks>

var q = Convert.ToInt32(Console.ReadLine());

var data = new string[q];
for (var i = 0; i < q; i++) data[i] = string.Empty;

var data_cnt = 0;
var r = new StringBuilder();

for (var i = 0; i < q; i++) {
    var v = Console.ReadLine()?.Split(' ');
    if (v == null) continue;
    switch (v.Length) {
        case 1:
            r.AppendLine(data[--data_cnt]);
            break;
        case 2:
            data[data_cnt++] = v[1];
            break;

        default:
            break;
    }
    for (var j = 0; j < data_cnt; j++) {
        r.Append($"{(j != 0 ? " " : "")}{data[j]}");
    }
    r.AppendLine();
}

Console.WriteLine(r.ToString());
