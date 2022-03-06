/// <summary>
/// スポーツの人数
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_001/forest_contest_001__d_sports/edit?language_uid=c-sharp</remarks>
var memberInfo = new Dictionary<string, int> {
    {"baseball", 9 }, {"soccer", 11 }, {"rugby", 15 }, {"basketball", 5 }, {"volleyball", 6 }
};

var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

Console.WriteLine(memberInfo[s]);
