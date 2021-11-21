/// <summary>
/// 全ての要素の和 
/// </summary>
/// <remarks></remarks>
var n = Convert.ToInt32(Console.ReadLine());
var sum = 0;
for(var i = 0; i < n; i++) {
    sum += Convert.ToInt32(Console.ReadLine());
}

// 結果の表示
Console.WriteLine(sum);
