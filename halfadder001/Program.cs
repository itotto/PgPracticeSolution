/// <summary>
/// 半加算器
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step8/edit?language_uid=c-sharp</remarks>

var v = Console.ReadLine()?.Split(' ');
if (v == null) return;

var a = v[0] == "1";
var b = v[1] == "1";

// 結果の表示
Console.WriteLine($"{(a && b ? "1" : "0")} {(a ^ b ? "1" : "0")}");
