/// <summary>
/// queue (9) 係
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__queue/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());

var q = new MyQueue(n);
for(var i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    if (vals.Length == 1) {
        q.Dequeue();
    } else if (vals.Length == 2) {
        q.Enqueue(vals[1]);
    }
}

q.PrintAll();


/// <summary>
/// 自作のQueueクラス
/// </summary>
public class MyQueue {
    private string[] _data = new string[0];

    private int _dataCount = 0;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="n"></param>
    public MyQueue(int n) => _data = new string[n]; 

    public void Enqueue(string s) {
        _data[_dataCount++] = s;
    }

    public void Dequeue() {
        if (_dataCount == 0) return;
        for (var i = 0; i < _dataCount - 1; i++) {
            _data[i] = _data[i + 1];
        }
        _dataCount--;
    }

    public void PrintAll() {
        for (var i = 0; i < _dataCount; i++) Console.WriteLine(_data[i]);
    }
}
