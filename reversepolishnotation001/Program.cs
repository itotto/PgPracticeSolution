/// <summary>
/// 逆ポーランド記法
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__practice_step3/edit?language_uid=c-sharp</remarks>

// 計算式
Func<int, int, string, int> calc = (a, b, o) => o == "+" ? a + b : a - b;

// 判定式
Func<string, bool> isoperator = (c) => c == "+" || c == "-";

// 個数は不要なので捨てる
_ = Convert.ToInt32(Console.ReadLine());

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;

var stack = new Stack<int>();

foreach (var v in vals) {
    if (isoperator(v)) {
        var v2 = stack.Pop();
        var v1 = stack.Pop();

        var r = calc(v1, v2, v);
        stack.Push(r);
    } else {
        stack.Push(Convert.ToInt32(v));
    }
}

// 結果の表示
Console.WriteLine(stack.Pop());

