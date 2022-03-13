

using System.Collections.Generic;
using System.Text;
/// <summary>
/// 構造体の作成
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__make/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var r = new StringBuilder();

for (var i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    r.AppendLine("User{");
    r.AppendLine($"nickname : {vals[0]}");
    r.AppendLine($"old : {vals[1]}");
    r.AppendLine($"birth : {vals[2]}");
    r.AppendLine($"state : {vals[3]}");
    r.AppendLine("}");
}

Console.Write(r.ToString());
