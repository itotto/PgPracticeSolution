

using System.Collections.Generic;
/// <summary>
/// セール販売
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_002/forest_contest_002__c_sale/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());

var sum = 0;
var isPantsBought = false;

for (var i = 0; i < n; i++) {
    var vals = Console.ReadLine()?.Split(' ');
    if (vals == null) return;
    sum += Convert.ToInt32(vals[1]);
    if (vals[0] == "pants") isPantsBought = true;
}

// 結果の表示
Console.WriteLine(isPantsBought && sum >= 2000 ? sum - 500 : sum);

