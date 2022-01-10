using System.Text;
/// <summary>
/// 3 行の入力
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__read_line_step3/edit?language_uid=c-sharp</remarks>

var r = new StringBuilder();
r.AppendLine(Console.ReadLine());
r.AppendLine(Console.ReadLine());
r.AppendLine(Console.ReadLine());

// 結果の表示
Console.WriteLine(r.ToString());
