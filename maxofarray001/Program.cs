// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
var n = Convert.ToInt32(Console.ReadLine());

var list = new List<int>();
for (int i = 0; i < n; i++) {
    list.Add(Convert.ToInt32(Console.ReadLine()));
}

list.Sort((x, y) => x - y);

// 結果の表示
Console.WriteLine(list[list.Count - 1]);

