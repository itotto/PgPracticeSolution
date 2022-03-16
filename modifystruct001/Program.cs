/// <summary>
/// 構造体の更新
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__change/edit?language_uid=c-sharp</remarks>

var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;
var n = Convert.ToInt32(inputs[0]);
var k = Convert.ToInt32(inputs[1]);
var members = new List<UserInfo>(n);

// 入力
for (int i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    members.Add(new UserInfo { NickName = vals[0], Old = Convert.ToInt32(vals[1]), Birthday = vals[2], State = vals[3] });
}

// 変更
for (var i = 0; i < k; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    var m_no = Convert.ToInt32(vals[0]);
    members[m_no - 1].NickName = vals[1];
}

// 結果を表示
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


