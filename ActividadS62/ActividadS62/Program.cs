var numbers = new List<int> { };
int[] scores = { 90, 71, 82, 93, 75, 82 };
var query = scores.Where(score => score > 80).OrderByDescending(score => score);

Console.WriteLine("Resultados:");
foreach (var score in query)
{
    Console.WriteLine(score);
}
