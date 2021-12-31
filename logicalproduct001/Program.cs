/// <summary>
/// 論理積( AND )の基本
/// </summary>
/// <remarks></remarks>
var v = Console.ReadLine()?.Split(' ');
if (v == null) return;

// 結果の表示
Console.WriteLine(v[0] == "1" && v[1] == "1" ? "1" : "0");
