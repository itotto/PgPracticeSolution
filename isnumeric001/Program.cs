/// <summary>
/// 数値判定
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step4/edit?language_uid=c-sharp</remarks>

var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

var minValue = (int)'0';
var maxValue = (int)'9';

var isnumeric = true;

foreach (var c in s) {
    if (c < minValue || maxValue < c) {
        isnumeric = false;
        break;
    }
}

// 結果の表示
Console.WriteLine(isnumeric ? "YES" : "NO");
