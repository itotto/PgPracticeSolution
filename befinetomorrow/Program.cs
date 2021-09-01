using System;
using System.Collections.Generic;

namespace befinetomorrow {
    /// <summary>
    /// 明日天気にな〜れ
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d4_weather/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            Func<string, string> getforecast = (s) => {
                if (s == "forward") return "Sunny";
                else if (s == "reverse") return "Rainy";
                else if (s == "sideways") return "Cloudy";
                else return string.Empty;
            };

            var n = Convert.ToInt32(Console.ReadLine());
            var result = new List<string>(n);
            for (var i = 0; i < n; i++) {
                result.Add(Console.ReadLine());
            }

            result.ForEach(r => Console.WriteLine(getforecast(r)));
        }
    }
}
