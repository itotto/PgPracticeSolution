using System.Text;
/// <summary>
/// クラスのメンバの更新
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__change_member/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());

var employees = new List<employee>(n);

var r = new StringBuilder();

for (int i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    switch (vals.Length) {
        case 2:
            var pos = Convert.ToInt32(vals[1]) - 1;
            if (vals[0] == "getnum") r.AppendLine($"{employees[pos].number}");
            else if (vals[0] == "getname") r.AppendLine($"{employees[pos].name}");
            break;

        case 3:
            if (vals[0] == "make")
                employees.Add(new employee { name = vals[2], number = Convert.ToInt32(vals[1]) });
            else {
                var changePos = Convert.ToInt32(vals[1]) - 1;
                if (vals[0] == "change_num") employees[changePos].number = Convert.ToInt32(vals[2]);
                else if (vals[0] == "change_name") employees[changePos].name = vals[2];
            }
            break;
    }
}

// 結果の表示
Console.WriteLine($"{r}");


class employee {
    public int number { get; set; }
    public string name { get; set; } = string.Empty;
}
