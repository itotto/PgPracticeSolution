using System.Text;
/// <summary>
/// 巨大な数の足し算
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step11/edit?language_uid=c-sharp</remarks>
var r = new StringBuilder();

var s = Console.ReadLine();
var t = Console.ReadLine();
if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

var maxlen = s.Length > t.Length ? s.Length : t.Length;

s = s.PadLeft(maxlen, '0');
t = t.PadLeft(maxlen, '0');

var carryUp = 0;
for (var i = s.Length - 1; i >= 0; i-- ){
    var result = Convert.ToInt32(s[i] - '0') + Convert.ToInt32(t[i] - '0') + carryUp;
    r.Insert(0, result % 10);
    carryUp = result / 10;
}
if (carryUp > 0) r.Insert(0, carryUp);

// 結果の表示
Console.WriteLine(r.ToString());
