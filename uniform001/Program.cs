/// <summary>
/// 競輪のユニフォーム
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/forest_contest_002/forest_contest_002__d_keirin/edit?language_uid=c-sharp</remarks>

var n = Convert.ToInt32(Console.ReadLine());
var c = string.Empty;
switch (n) {
    case 1:
        c = "white";
        break;
    case 2:
        c = "black";
        break;
    case 3:
        c = "red";
        break;
    case 4:
        c = "blue";
        break;
    case 5:
        c = "yellow";
        break;
    case 6:
        c = "green";
        break;
    case 7:
        c = "orange";
        break;
    case 8:
        c = "pink";
        break;
    case 9:
        c = "purple";
        break;
}

// 結果の表示
Console.WriteLine(c);
