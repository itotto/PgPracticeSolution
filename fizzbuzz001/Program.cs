using System;

namespace fizzbuzz001 {
    /// <summary>
    /// Fizz Buzz
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/skillcheck_sample/fizz-buzz/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= n; i++) {
                var surplus3 = i % 3;
                var surplus5 = i % 5;

                if (surplus3 == 0 && surplus5 == 0) {
                    Console.WriteLine("Fizz Buzz");
                } else if (surplus3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (surplus5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
