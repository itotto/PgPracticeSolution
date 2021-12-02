/// <summary>
/// 数値の出現率
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/data_structure/data_structure__dict_step1/edit?language_uid=c-sharp</remarks>
_ = Convert.ToInt32(Console.ReadLine());

var nc = new Dictionary<char, int> {
    { '0',  0}, { '1', 0 }, { '2', 0 }, { '3', 0 }, { '4', 0 },
    { '5', 0 }, { '6', 0 }, { '7', 0 }, { '8', 0 }, { '9', 0 },
};

var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;

foreach (var a in inputs) nc[a[0]]++;


// 結果の表示
Console.WriteLine($"{nc['0']} {nc['1']} {nc['2']} {nc['3']} {nc['4']} {nc['5']} {nc['6']} {nc['7']} {nc['8']} {nc['9']}");
