using System.Diagnostics;
{
    var path = "C:\\Users\\user\\Desktop\\Text1.txt";
    StreamReader sr = new StreamReader(path);
    string text = sr.ReadToEnd();
    var watchTwo = Stopwatch.StartNew();

    LinkedList<string> strings = new LinkedList<string>();
    strings.AddFirst(text);
    foreach (var i in strings)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
}
