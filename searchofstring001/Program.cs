/// <summary>
/// 文字列の検索
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step9/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
var t = Console.ReadLine();
if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

var bFound = false;
for (var i = 0; i < s.Length; i++) {
    if (s[i] == t[0]) {
        var isMatch = true;
        for (var j = 1; j < t.Length; j++) {
            if (s[i + j] != t[j]) {
                isMatch = false;
                break;
            }
        }
        if (isMatch) {
            bFound = true;
            break;
        }
    }
}

// 結果の表示
Console.WriteLine(bFound ? "YES" : "NO");
