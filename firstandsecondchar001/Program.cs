using System;

namespace firstandsecondchar001 {
    /// <summary>
    /// 文字列の１、２文字目
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prob60/count_string_3/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var str = Console.ReadLine();

            // 結果の表示
            Console.WriteLine($"{str[0]} {str[1]}");
        }
    }
}
