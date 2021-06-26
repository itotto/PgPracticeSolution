using System;
using System.Collections.Generic;

namespace matchinggame001 {
    /// <summary>
    /// 神経衰弱
    /// </summary>
    ///<remarks>https://paiza.jp/works/mondai/skillcheck_archive/concentration/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            Func<int, int, string> getKey = (y, x) => $"{y}={x}";

            // 初期条件
            var conditions = Console.ReadLine().Split(' ');
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);
            var numberOfPlayers = Convert.ToInt32(conditions[2]);

            var result = new Dictionary<int, int>(numberOfPlayers); // 結果
            var order = new Queue<int>(numberOfPlayers); // 順番
            for (var p = 1; p <= numberOfPlayers; p++) {
                result.Add(p, 0);
                order.Enqueue(p);
            }

            // カードの状態(key:y=x, val:true(残ってる),false(除去済み)
            var cardstatus = new Dictionary<string, bool>(height * width);

            // カードを読み取り
            var cards = new byte[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine().Split(' ');
                for (var j = 0; j < width; j++) {
                    cards[i, j] = Convert.ToByte(line[j]);
                    cardstatus.Add(getKey(i+1, j+1), true);
                }
            }

            // 記録
            var numberOfRecords = Convert.ToInt32(Console.ReadLine());
            var isChange = true;
            var playerNum = -1;
            var allSheets = height * width;
            var matchCount = 0;
            for (var k = 0; k < numberOfRecords; k++) {

                if (isChange) {
                    playerNum = order.Dequeue();
                    order.Enqueue(playerNum);
                }
                var targetCards = Console.ReadLine().Split(' ');
                var y1 = Convert.ToInt32(targetCards[0]);
                var x1 = Convert.ToInt32(targetCards[1]);
                var y2 = Convert.ToInt32(targetCards[2]);
                var x2 = Convert.ToInt32(targetCards[3]);

                var key1 = getKey(y1, x1);
                var key2 = getKey(y2, x2);

                // どちらも取り除かれていない場合のみ処理
                if (cardstatus[key1] && cardstatus[key2]) {

                    // 一致したら除去
                    if (cards[y1 - 1, x1 - 1] == cards[y2 - 1, x2 - 1]) {
                        cardstatus[key1] = false;
                        cardstatus[key2] = false;
                        result[playerNum] += 2;
                        matchCount += 2;

                        isChange = false;

                        // カードがすべてオープンしたらおしまい
                        if (matchCount == allSheets) break;
                    } else {
                        isChange = true;
                    }
                }
            }

            // 結果を表示
            for (var x = 1; x <= numberOfPlayers; x++) Console.WriteLine(result[x]);
        }
    }
}
