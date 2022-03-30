/// <summary>
/// 長方形の面積
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_002/forest_contest_002__d_rectangular/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var area = Convert.ToInt32(vals[0]) * Convert.ToInt32(vals[1]);

// 結果の表示
Console.WriteLine(area == 0 ? "invalid" : area.ToString());
