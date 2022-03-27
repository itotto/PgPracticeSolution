
/// <summary>
///  デフォルト引数
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/class_primer/class_primer__set_default/edit?language_uid=c-sharp</remarks>
const int BEER_COST = 500;

var inputs = Console.ReadLine()?.Split(' ');
if (inputs == null) return;
var n = Convert.ToInt32(inputs[0]);
var k = Convert.ToInt32(inputs[1]);

// ユーザー情報の初期化
var customers = new List<PubCustomer>(n);
for (var i = 0; i < n; i++) {
    customers.Add(new PubCustomer(Convert.ToInt32(Console.ReadLine())));
}

// 支払いの入力
for (var i = 0; i < k; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    var idx = Convert.ToInt32(vals[0]) - 1;
    var cost = 0;
    if (vals.Length == 3) {
        cost = Convert.ToInt32(vals[2]);
        switch (vals[1]) {
            case "food":
                cost -= customers[idx].IsAlcohoolOrdered ? 200 : 0;
                break;

            case "alcohol":
                if (customers[idx].IsAdult) {
                    customers[idx].IsAlcohoolOrdered = true;
                } else {
                    cost = 0;
                }
                break;

            case "softdrink":
                break;

            default:
                break;
        }
    } else if (vals.Length == 2) {
        if (customers[idx].IsAdult) {
            cost = BEER_COST;
            customers[idx].IsAlcohoolOrdered = true;
        }
    }

    customers[idx].AmountOfOrders += cost;
}

// 結果の表示
customers.ForEach(c => Console.WriteLine(c.AmountOfOrders));


class PubCustomer {
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="old"></param>
    public PubCustomer(int old) => Old = old;

    public int Old { get; set; }

    public bool IsAlcohoolOrdered { get; set; } = false;

    public bool IsAdult { get => Old >= 20; }

    public int AmountOfOrders { get; set; } = 0;
}
