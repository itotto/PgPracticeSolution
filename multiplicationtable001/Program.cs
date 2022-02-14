/// <summary>
/// 九九表
/// </summary>
/// <remarks>https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduse_easy/edit?language_uid=c-sharp</remarks>

const int ARRAYSIZE = 9;

for (int i = 1; i <= ARRAYSIZE; i++) {
    for (int j = 1; j <= ARRAYSIZE; j++) {
        Console.Write($"{(j == 1 ? string.Empty : " ")}{i * j}");
    }
    Console.WriteLine();
}
