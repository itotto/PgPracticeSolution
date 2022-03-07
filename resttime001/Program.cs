/// <summary>
/// バイトの休憩時間
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_001/forest_contest_001__d_break_time/edit?language_uid=c-sharp</remarks>

var h = Convert.ToInt32(Console.ReadLine());

// 結果の表示
Console.WriteLine(h <= 6 ? "no break" : $"{(h > 8 ? 60 : 45)} min");
