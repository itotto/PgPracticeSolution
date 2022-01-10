using System.Text;
/// <summary>
/// 10 行の入力
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__read_line_step4/edit?language_uid=c-sharp</remarks>

var r = new StringBuilder();
for (var i = 0; i < 10; i++) {
    r.AppendLine(Console.ReadLine());
}

// 結果の表示
Console.WriteLine(r.ToString());
