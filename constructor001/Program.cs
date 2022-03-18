
using System.Text;
/// <summary>
/// コンストラクタ
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__constructor/edit?language_uid=c-sharp</remarks>

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
            employees.Add(new employee(Convert.ToInt32(vals[1]), vals[2]));
            break;

    }
}

Console.WriteLine(r.ToString());


class employee {
    public employee(int newnumber, string newname) {
        name = newname;
        number = newnumber;
    }
    public int number { get; set; }
    public string name { get; set; } = string.Empty;
}

