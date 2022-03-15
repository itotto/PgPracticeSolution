/// <summary>
/// 構造体の整列
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__sort/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());
var members = new List<UserInfo>(n);

for (int i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    members.Add(new UserInfo { NickName = vals[0], Old = Convert.ToInt32(vals[1]), Birthday = vals[2], State = vals[3] });
}

// 並び替え
members.Sort((a,b ) => a.Old - b.Old);
// 
members.ForEach(m => Console.WriteLine($"{m.NickName} {m.Old} {m.Birthday} {m.State}"));


/// <summary>
/// ユーザー情報
/// </summary>
class UserInfo {
    public string NickName { get; set; } = string.Empty;
    public int Old { get; set; }
    public string Birthday { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
}
