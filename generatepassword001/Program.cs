/// <summary>
/// パスワード作成
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step6/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());
var q = Convert.ToInt32(Console.ReadLine());

var repChars = new Dictionary<int, string>(q);

// 入力
for (int i = 0; i < q; i++) {
    var inputs = Console.ReadLine()?.Split(' ');
    if (inputs == null) continue;
    repChars.Add(Convert.ToInt32(inputs[0]) - 1, inputs[1]);
}

var c = Console.ReadLine();
if (c == null) return;

// 結果の表示
for(var i = 0; i < n; i++) {
    Console.Write(repChars.ContainsKey(i) ? repChars[i] : c);
}
Console.WriteLine();
