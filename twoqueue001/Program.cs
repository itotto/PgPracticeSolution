using System.Text;
/// <summary>
/// 2つのキュー
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step1/edit?language_uid=c-sharp</remarks>
var countOfQueries = Convert.ToInt32(Console.ReadLine());

// 最大値で配列を作る
var q1 = new string[countOfQueries];
var q2 = new string[countOfQueries];

for (var i = 0; i < countOfQueries; i++) {
    q1[i] = string.Empty;
    q1[i] = string.Empty;
}

var cnt_q1 = 0;
var cnt_q2 = 0;

var r = new StringBuilder();

for (int i = 0; i < countOfQueries; i++) {
    var v = Console.ReadLine()?.Split(' ');
    if (v == null) continue;

    // 1つのときはサイズを表示する
    if (v.Length == 1) {
        r.AppendLine($"{cnt_q1} {cnt_q2}");
    } else if (v.Length == 2) {
        if (v[1] == "1") {
            r.AppendLine(q1[0]);
            for (var j = 1; j <= cnt_q1;j++) {
                q1[j - 1] = q1[j];
            }
            q1[cnt_q1] = string.Empty;

            cnt_q1--;
        } else if (v[1] == "2") {
            r.AppendLine(q2[0]);
            for (var j = 1; j <= cnt_q2;j++) {
                q2[j - 1] = q2[j];
            }
            q2[cnt_q2] = string.Empty;
            cnt_q2--;
        }

    } else if (v.Length == 3) {
        if (v[1] == "1") q1[cnt_q1++] = v[2];
        else if (v[1] == "2") q2[cnt_q2++] = v[2];
    }
}

// 結果の表示
Console.WriteLine(r.ToString());

