/// <summary>
/// 集団行動
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__group_move/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var q = Convert.ToInt32(vals[1]);

var data = new MyArray(n);

for (var i = 0; i < q; i++) {
    var orders = Console.ReadLine()?.Split(' ');
    if (orders == null) return;
    switch (orders.Length) {
        case 1: // reverse
            data.Reverse();
            break;

        case 2: // resize
            data.Resize(Convert.ToInt32(orders[1]));
            break;

        case 3: // swap
            data.Swap(Convert.ToInt32(orders[1]), Convert.ToInt32(orders[2]));
            break;
    }

}
data.PrintAllData();



/// <summary>
/// 指定した操作を行うための独自配列クラス
/// </summary>
public class MyArray {
    public int Count { get; set; }

    private int[] _data = new int[0];

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="count"></param>
    public MyArray(int count) {
        Count = count;
        _data = new int[count];
        for (var i = 0; i < count; i++) {
            _data[i] = i + 1;
        }
    }

    /// <summary>
    /// 交換
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public void Swap(int a, int b) {
        a--; b--; // 指定位置とインデックスが1ずれるので整合させる
        var tmp = _data[a];
        _data[a] = _data[b];
        _data[b] = tmp;
    }

    /// <summary>
    /// 逆転
    /// </summary>
    public void Reverse() {
        var tmp = new int[Count];
        Array.Copy(_data, tmp, Count);
        for (var i = Count - 1; i >= 0; i--) {
            _data[Count - i - 1] = tmp[i];
        }
    }

    /// <summary>
    /// 配列のサイズ変更
    /// </summary>
    /// <param name="newSize"></param>
    public void Resize(int newSize) {
        if (newSize >= Count) return;
        Count = newSize;
        Array.Resize(ref _data, newSize);
    }

    public void PrintAllData() {
        if (Count == 0) return;
        for (var i = 0; i < Count; i++) Console.WriteLine(_data[i]);
    }
}
