using System.Text;
/// <summary>
/// 表記の訂正
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/string_primer/advance_step7/edit?language_uid=c-sharp</remarks>
var s = Console.ReadLine();
if (string.IsNullOrEmpty(s)) return;

// check1
if (s[0] == '0') {
    var pos = -1;
    for (int i = 1; i < s.Length; i++) {
        if (s[i] == '0') continue;
        if (s[i] == '.') {
            pos = i - 1;
        } else if (s[i] != '0') {
            pos = i;
        }

        s = s.Substring(pos, s.Length - pos);
        break;
    }
}
// debug
//Console.WriteLine(s);

// check2
if (s.IndexOf('.') >= 0 && s[s.Length - 1] == '0') {
    var len = 0;
    for (var i = s.Length - 1; i >= 0; i--) {
        if (s[i] != '0') break;
        len++;
    }
    s = s.Substring(0, s.Length - len);
}
//Console.WriteLine(s);

// check3
if (s.IndexOf('.') >= 0) {
    var r = new StringBuilder();

    var notFound = true;
    foreach (var c in s) {
        if (c != '.' || notFound) {
            r.Append(c);
            if (c == '.')  notFound = false;
        }
    }
    s = r.ToString();
}

// 結果の表示
Console.WriteLine(s);

