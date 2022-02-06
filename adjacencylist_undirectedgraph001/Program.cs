


using System.Collections.Generic;
/// <summary>
/// 隣接リストの出力・無向グラフ
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/graph_input_problems/graph_input_problems__adjacency_list_step1/edit?language_uid=c-sharp</remarks>

var vals = Console.ReadLine()?.Split(' ');
if (vals == null) return;
var countOfVertexes = Convert.ToInt32(vals[0]);
var counteOfSides = Convert.ToInt32(vals[1]);
