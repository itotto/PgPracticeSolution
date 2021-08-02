using System;
using System.Collections.Generic;

namespace exceptionhandling001 {
    /// <summary>
    /// 例外処理のタブーサーチ
    /// </summary>
    /// <remarks>https://paiza.jp/works/mondai/steinsgate/restore_command_boss/edit?language_uid=c-sharp</remarks>
    class Program {
        static void Main() {
            // 初期条件
            var initConditions = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(initConditions[0]);
            var m = Convert.ToInt32(initConditions[1]);
            var l = Convert.ToInt32(initConditions[2]);

            // コマンドを入力
            var commandSums = new int[n]; // 各行ごとの和
            var commands = new List<int[]>(n); // コマンド
            for (var i = 0; i < n; i++) {
                var commandline = Console.ReadLine().Split(' ');
                var cmd = new int[m];

                commandSums[i] = 0;
                for (var j = 0; j < m; j++) {
                    cmd[j] = Convert.ToInt32(commandline[j]);
                    commandSums[i] += cmd[j];
                }
                commands.Add(cmd);
            }

            // パラメーターを入力
            var paramSums = new int[l]; // 各行ごとの和
            var parameters = new List<int[]>(l);
            for (var i = 0; i < l; i++) {
                var paramline = Console.ReadLine().Split(' ');
                var prm = new int[m];
                paramSums[i] = 0; // 初期化
                for (var j = 0; j < m; j++) {
                    prm[j] = Convert.ToInt32(paramline[j]);
                    paramSums[i] += prm[j];
                }
                parameters.Add(prm);
            }

            // 比較
            for (var i = 1; i < l; i++) {
                var sum = paramSums[i] - paramSums[i - 1]; // 差分の和を計算
                var diffs = new int[m];

                // 差分を計算
                var p1 = parameters[i - 1];
                var p2 = parameters[i];

                for (var j = 0; j < m; j++) {
                    diffs[j] = p2[j] - p1[j];
                }

                for (var j = 0; j < n; j++) {
                    if (commandSums[j] == sum) {
                        var targetCmd = commands[j];
                        var found = true;
                        for (var k = 0; k < m; k++) {
                            if (diffs[k] != targetCmd[k]) {
                                found = false;
                                break;
                            }
                        }

                        if (found) {
                            Console.WriteLine(j + 1);
                            break;
                        }
                    }
                }
            }

        }
    }
}
