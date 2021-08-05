using System;
using System.Collections.Generic;
using System.Text;

namespace dungeondeadlock002 {
    /// <summary>
    /// ダンジョンのデッドロック 2
    /// </summary>
    /// <!-- dungeondeadlock001と同じ-->
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/moving_deadlock_step2/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            const int NOT_EXISTS = -1;

            // 初期条件
            var initConditions = Console.ReadLine().Split(' ');
            var numberOfRooms = Convert.ToInt32(initConditions[0]);
            var numberOfPlayers = Convert.ToInt32(initConditions[1]);
            var judgeCount = Convert.ToInt32(initConditions[2]);

            // 部屋情報を初期化
            var rooms = new Dictionary<int, int>(numberOfRooms);
            for (var i = 1; i <= numberOfRooms; i++) {
                rooms.Add(i, NOT_EXISTS);
            }

            // プレイヤーの所在を初期化
            for (var i = 1; i <= numberOfPlayers; i++) {
                var roomNumber = Convert.ToInt32(Console.ReadLine());
                // 本当は確認はいらないはずだけど
                if (rooms.ContainsKey(roomNumber)) {
                    rooms[roomNumber] = i;
                } else {
                    rooms.Add(roomNumber, i);
                }
            }

            // 移動情報を入力
            var result = new StringBuilder();
            for (var i = 0; i < judgeCount; i++) {
                var moveInfo = Console.ReadLine().Split(' ');
                var targetPlayNumber = Convert.ToInt32(moveInfo[0]);
                var nextRoomNumber = Convert.ToInt32(moveInfo[1]);

                var r = "No";
                //
                if (rooms.ContainsKey(nextRoomNumber)) {
                    var nextPlayNo = rooms[nextRoomNumber];
                    if (nextPlayNo == NOT_EXISTS || nextPlayNo == targetPlayNumber) {
                        r = "Yes";
                    }
                }
                result.AppendLine(r);
            }

            // 結果の表示
            Console.WriteLine(result.ToString());
        }
    }
}
