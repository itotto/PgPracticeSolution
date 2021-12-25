/// <summary>
/// 数式の計算（1桁）
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step8/edit?language_uid=c-sharp</remarks>

var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

var answer = Convert.ToInt32(s[0] - '0');
for (int i = 1; i < s.Length - 1; i += 2) {
    if (s[i] == '+') answer += Convert.ToInt32(s[i + 1] - '0');
    else answer -= Convert.ToInt32(s[i + 1] - '0');
}

// 結果の表示
Console.WriteLine(answer);
