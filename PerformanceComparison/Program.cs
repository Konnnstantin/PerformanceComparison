using System.Diagnostics;
{
    var path = "C:\\Users\\user\\Desktop\\Text1.txt";
    StreamReader sr = new StreamReader(path);
    string text = sr.ReadToEnd();

    var watchTwo = Stopwatch.StartNew();

    List<string> list = new List<string>();
    list.Add(text);
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
}
