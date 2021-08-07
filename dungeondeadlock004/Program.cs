using System;
using System.Collections.Generic;

namespace dungeondeadlock004 {
    /// <summary>
    /// ダンジョンのデッドロック 4
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/moving_deadlock_step4/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 誰も部屋にいない
            const int NOT_EXISTS = -1;

            // 初期条件を入力
            var initInput = Console.ReadLine().Split(' ');
            var numberOfRooms = Convert.ToInt32(initInput[0]);
            var numberOfPlayers = Convert.ToInt32(initInput[1]);

            // 部屋の情報を初期化(key:部屋番号, value:いまいるプレイヤーの番号[初期値は不在])
            var rooms = new Dictionary<int, int>(numberOfRooms);
            for (var i = 1; i <= numberOfRooms; i++) rooms.Add(i, NOT_EXISTS);

            // 移動情報の入力
            // key:プレイヤーの番号, value:次に移動する部屋番号
            var nextRooms = new Dictionary<int, int>(numberOfPlayers);
            for (var i = 1; i <= numberOfPlayers; i++) {
                var moveInfo = Console.ReadLine().Split(' ');
                var current = Convert.ToInt32(moveInfo[0]);
                var next = Convert.ToInt32(moveInfo[1]);

                rooms[current] = i;
                nextRooms.Add(i, next);
            }

            // 移動をチェック
            var isDeadlock = false;
            var moves = new List<int>();
            var nextPlayer = 1;
            while (true) {
                moves.Add(nextPlayer);
                var nextRoom = nextRooms[nextPlayer];
                var nextPlayer_w = rooms[nextRoom];
                if (nextPlayer_w == nextPlayer) break;
                if (nextPlayer_w == NOT_EXISTS) break;
                if (moves.Contains(nextPlayer_w)) {
                    isDeadlock = true;
                    break;
                }
                nextPlayer = nextPlayer_w;
            }


            // 結果を表示
            Console.WriteLine(isDeadlock ? "Yes" : "No");
            if (!isDeadlock) {
                var startCnt = moves.Count - 1;
                for (var i = startCnt; i >= 0; i--) {
                    Console.Write($"{(i == startCnt ? string.Empty : " ")}{moves[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
