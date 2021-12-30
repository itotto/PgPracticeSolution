
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 巨大な数のかけ算
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step12/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var t = Convert.ToInt32(Console.ReadLine());
if (string.IsNullOrEmpty(s)) return;

var result = t == 0 ? "0" :s;
for (var i = 0; i < t - 1; i++) {
    result = AddNumber(s, result);
}

Console.WriteLine(result);


static string AddNumber(string s, string t) {
    var r = new StringBuilder();
    var maxlen = s.Length > t.Length ? s.Length : t.Length;

    s = s.PadLeft(maxlen, '0');
    t = t.PadLeft(maxlen, '0');

    var carryUp = 0;
    for (var i = s.Length - 1; i >= 0; i--) {
        var result = Convert.ToInt32(s[i] - '0') + Convert.ToInt32(t[i] - '0') + carryUp;
        r.Insert(0, result % 10);
        carryUp = result / 10;
    }
    if (carryUp > 0) r.Insert(0, carryUp);
    return r.ToString();
};

