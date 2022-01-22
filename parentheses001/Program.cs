/// <summary>
/// 括弧列
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step4/edit?language_uid=c-sharp</remarks>

_ = Convert.ToInt32(Console.ReadLine());

var str = Console.ReadLine();
if (string.IsNullOrEmpty(str)) return;

var cnt = 0;
foreach (var c in str) {
    if (c == '(') cnt++;
    else if (c == ')') cnt--;
    if (cnt < 0) break;
}

// 結果の表示
Console.WriteLine(cnt == 0 ? "Yes" : "No");
