/// <summary>
/// 重複の削除
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step5/edit?language_uid=c-sharp</remarks>

var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

var nums = new Dictionary<char, bool>();

foreach (var c in s) {
    if (!nums.ContainsKey(c)) {
        nums.Add(c, true);
        Console.Write(c);
    }
}
