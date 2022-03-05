/// <summary>
/// ソートと検索 (query)
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/query_primer/query_primer__sort_find_multi/edit?language_uid=c-sharp</remarks>
var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var n = Convert.ToInt32(vals[0]);
var k = Convert.ToInt32(vals[1]);
var myheight = Convert.ToInt32(vals[2]);

var data = new int[n + 1];
data[0] = myheight;

for (var i = 1; i <= n; i++) {
    data[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(data);
var pos = Array.BinarySearch(data, myheight) + 1;

for (var i = 0; i < k; i++) {
    var evt = Console.ReadLine()?.Split(' ');
    if (evt == null) continue;

    switch (evt.Length) {
        case 1:
            Console.WriteLine(pos);
            break;

        case 2:
            var newstudentheight = Convert.ToInt32(evt[1]);
            if (newstudentheight < myheight) pos++;
            break;
    }
}

