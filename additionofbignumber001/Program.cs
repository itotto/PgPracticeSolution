using System.Text;
/// <summary>
/// 巨大な数の足し算(繰り上がりなし)
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step10/edit?language_uid=c-sharp</remarks>

var r = new StringBuilder();

var s = Console.ReadLine();
var t = Console.ReadLine();
if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

var maxlen = s.Length > t.Length ? s.Length : t.Length;

s = s.PadLeft(maxlen, '0');
t = t.PadLeft(maxlen, '0');

for(var i = 0; i < s.Length; i++) {
    //r.Insert(0, $"{Convert.ToInt32(s[i] - '0') + Convert.ToInt32(t[i] - '0')}");
    r.Append($"{Convert.ToInt32(s[i] - '0') + Convert.ToInt32(t[i] - '0')}");
}

// 結果の表示
Console.WriteLine(r.ToString());
