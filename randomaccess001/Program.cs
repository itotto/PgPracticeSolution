/// <summary>
/// ランダムアクセス
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__array_step1?language_uid=c-sharp</remarks>
var inputs = Console.ReadLine()?.Split(' ');
_ = Convert.ToInt32(inputs?[0]);
var m = Convert.ToInt32(inputs?[1]);

// 結果の表示
Console.WriteLine(Console.ReadLine()?.Split(' ')[m - 1]);

