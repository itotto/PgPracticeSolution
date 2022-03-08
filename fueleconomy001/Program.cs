/// <summary>
/// 自動車の燃費
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_001/forest_contest_001__d_car_fuel/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var v = Convert.ToInt32(vals[0]);
var d = Convert.ToInt32(vals[1]);

// 結果の表示
Console.WriteLine($"{d / v}");

