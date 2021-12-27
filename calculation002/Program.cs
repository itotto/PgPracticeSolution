using System.Text;
/// <summary>
/// 数式の計算
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step9/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

var result = 0;
var isAdd = true;

var r = new StringBuilder();

foreach (var c in s) {
    if ('0' <= c && c <= '9') r.Append(c);
    else {
        if (r.Length > 0) {
            if (isAdd)
                result += Convert.ToInt32(r.ToString());
            else
                result -= Convert.ToInt32(r.ToString());
            r.Clear();
        }
        isAdd = c == '+';
    }
}
if (r.Length > 0) {
    if (isAdd)
        result += Convert.ToInt32(r.ToString());
    else
        result -= Convert.ToInt32(r.ToString());
}

// 結果の表示
Console.WriteLine(result);
