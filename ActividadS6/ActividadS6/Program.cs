var numbers = new List<int> { };
int[] scores = { 97, 92, 81, 60 };

var query = from score in scores
            where score > 80
            select score;

Console.WriteLine("Resultado:");
foreach (var score in query)
{
    Console.WriteLine(score);
}