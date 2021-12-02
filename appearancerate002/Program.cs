/// <summary>
/// 英小文字の出現率
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__dict_step2/edit?language_uid=c-sharp</remarks>
_ = Convert.ToInt32(Console.ReadLine());
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

// 初期化
var nc = new Dictionary<char, int>();
for (var i = (int)'a'; i<= (int)'z'; i++) nc[(char)i] = 0;

// データをチェック
foreach (var c in s) nc[c]++;

var sep = string.Empty;
for (var i = (int)'a'; i <= (int)'z'; i++) {
    Console.Write($"{sep}{nc[(char)i]}");
    if (string.IsNullOrEmpty(sep)) sep = " ";
}
Console.WriteLine();
