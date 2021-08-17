using System;

namespace duplicationcountstring001 {
    class Program {
        static void Main() {
            var s = Console.ReadLine();
            var targetStr = Console.ReadLine();
            var cnt = 0;

            for (var i = 0; i < targetStr.Length - 1; i++) {
                var match = true;
                for (var j = 0; j < s.Length; j++) {
                    if (s[j] != targetStr[i + j]) {
                        match = false;
                        break;
                    }
                }
                if (match) cnt++;
            }

            // 結果の表示
            Console.WriteLine(cnt);
        }
    }
}
