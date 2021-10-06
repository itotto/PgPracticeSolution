using System;

namespace fermattest001 {
    /// <summary>
    /// フェルマーテスト
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/prime_number_primer/prime_number_primer__fermat_test/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int RANDOM_NUM = 2; // 今回は2固定
            var n = Convert.ToInt32(Console.ReadLine());

            var fermat = 1;
            for (var i = 1; i < n; i++) {
                fermat *= RANDOM_NUM;
                fermat %= n;
            }

            // 結果の表示
            Console.WriteLine(fermat == 1 ? "YES" : "NO");
        }
    }
}
