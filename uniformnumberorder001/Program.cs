/// <summary>
/// 背番号順
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_001/forest_contest_001__c_player_number/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var members = new List<PlayerInfo>(n);

for (var i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    members.Add(new PlayerInfo {
        PlayerNumber = Convert.ToInt32(vals[0]),
        PlayerName = vals[1],
    });
}

members.Sort((x, y) => x.PlayerNumber - y.PlayerNumber);
members.ForEach(m => Console.WriteLine($"{m.PlayerNumber} {m.PlayerName}"));


/// <summary>
/// 構造体クラス
/// </summary>
internal class PlayerInfo {
    /// <summary>
    /// プレイヤーの名前
    /// </summary>
    public string PlayerName { get; set; } = string.Empty;

    /// <summary>
    /// プレイヤー番号
    /// </summary>
    public int PlayerNumber { get; set; } = 0;
}
