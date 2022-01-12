﻿/// <summary>
/// 半角スペース区切りの2つの入力
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__split_input_step2/edit?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;

foreach (var v in inputs) Console.WriteLine(v);
