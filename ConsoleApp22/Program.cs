string input = Console.ReadLine();
List<string> numbers = input.Split(' ').ToList();
List<int> Numbers = new List<int>();
for (int i = 0; i<numbers.Count(); i++)
{
    Numbers.Add(int.Parse(numbers[i]));
}
for (int i = 0; i<Numbers.Count(); i++)
{
    if (Numbers[i]<0)
    {
        Numbers.RemoveAt(i);
        i--;//Индекса се връща назад защото при премахване на елемент, следващия се премества с 1 по наляво
    }
}
Numbers.Reverse();
string output = " ";
for (int i = 0; i<Numbers.Count(); i++)
{
    output+= Numbers[i]+ " ";
}
Console.WriteLine(output);
 