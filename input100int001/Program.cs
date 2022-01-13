/// <summary>
/// 100行の整数の入力
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stdin_primer/stdin_primer__integer_row_step4</remarks>
const int EXECTIMES = 100;

var list = new List<int>(EXECTIMES);
for (var i = 0; i < EXECTIMES; i++) {
    list.Add(Convert.ToInt32(Console.ReadLine()));
}

list.ForEach(l => Console.WriteLine(l));
