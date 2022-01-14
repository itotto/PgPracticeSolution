/// <summary>
/// スタック・キュー実装編( 共通問題 ) step 2
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/stack_queue/stack_queue__common_step2/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var data = new int[n];
var cnt = 0;
for(int i = 0; i < n; i++) {
    var v = Console.ReadLine()?.Split(' ');
    if (v == null || v.Length == 1) continue;
    data[cnt++] = Convert.ToInt32(v[1]); 
}
// 配列の大きさを変更する
Array.Resize(ref data, cnt);


Console.WriteLine(data.Length);
for (var i = 0; i < data.Length; i++) {
    Console.WriteLine(data[i]);
}
