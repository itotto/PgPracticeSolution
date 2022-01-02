﻿/// <summary>
/// 排他的論理和( XOR )の基本
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step4/edit?language_uid=c-sharp</remarks>

var v = Console.ReadLine()?.Split(' ');
if (v == null) return;

// 結果の表示
Console.WriteLine(v[0] == "1" ^ v[1] == "1" ? "1" : "0");
