/// <summary>
/// 回文判定
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/normal_step11/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;
var pos = s.Length - 1;
var isPalindrome = true;

for (var i = 0; i < s.Length; i++) {
    if (s[i] != s[pos - i]) {
        isPalindrome = false;
        break;
    }
}

// 結果の表示
Console.WriteLine(isPalindrome ? "YES" : "NO");

