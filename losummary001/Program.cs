/// <summary>
/// 論理演算を用いた計算のまとめ
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_boss/edit?language_uid=c-sharp</remarks>
var v = Console.ReadLine()?.Split(' ');
if (v == null) return;
var a = v[0] == "1";
var b = v[1] == "1";
var c = v[2] == "1";
var d = v[3] == "1";

// 結果の表示
Console.WriteLine(((a || b) && c) ^ d ? 1 : 0);
