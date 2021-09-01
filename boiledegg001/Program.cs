using System;

namespace boiledegg001 {
    /// <summary>
    /// ゆで卵
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/warset/d5_egg/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {

            var boiledTime = Convert.ToInt32(Console.ReadLine());

            var eggState = "hard boiled";

            if (boiledTime <= 5) eggState = "raw";
            else if (boiledTime <= 7) eggState = "soft boiled";

            Console.WriteLine(eggState);
        }
    }
}
