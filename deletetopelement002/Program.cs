using System.Text;
/// <summary>
/// 先頭の要素の削除(query)
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__multi_pop/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);

var q = new MyQueue(n);
for (var i = 0; i < n; i++) {
    var v = Console.ReadLine();
    if (string.IsNullOrEmpty(v)) continue;
    q.Add(v, i);
}

var r = new StringBuilder();

for (var i = 0; i < k; i++) {
    var v = Console.ReadLine();
    if (string.IsNullOrEmpty(v)) continue;

    switch (v) {
        case "show":
            r.Append(q.Show());
            break;

        case "pop":
            q.Pop();
            break;
    }
}

// 結果の表示
Console.WriteLine(r.ToString());



internal class MyQueue {
    private int _startIndex = 0;

    private string[] _data = null;

    public MyQueue(int size) => _data = new string[size];

    public void Add(string data, int pos) => _data[pos] = data;

    public void Pop() {
        if (_startIndex == _data.Length - 1) return;
        _startIndex++;
    }

    public string Show() {
        var r = new StringBuilder();
        for (var i = _startIndex; i < _data.Length; i++) {
            r.AppendLine(_data[i]);
        }
        return r.ToString();
    }
}
