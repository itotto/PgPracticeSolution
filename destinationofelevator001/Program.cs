/// <summary>
/// エレベーターの行き先
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_002/forest_contest_002__d_elevator/edit?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;
var currentFloor = Convert.ToInt32(inputs[0][0]);
var nextFloor = Convert.ToInt32(inputs[1][0]);

// 結果の表示
Console.WriteLine(currentFloor > nextFloor ? "down" : "up");

