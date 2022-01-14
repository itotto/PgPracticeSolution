/// <summary>
/// スタック・キュー実装編( 共通問題 ) step 1
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__common_step1/edit?language_uid=c-sharp</remarks>
var n = Convert.ToInt32(Console.ReadLine());

var data = new int[n];

for(var i = 0; i < n; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

// 結果の表示
Console.WriteLine(n);

for (var i = 0; i < n; i++) {
    Console.WriteLine(data[i]);
}

