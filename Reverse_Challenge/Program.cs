Console.WriteLine("");

string pangram = "The quick brown fox jumps over the lazy dog";
string result = string.Join(" ",
    pangram.Split(' ')
          .Select(word => new string(word.Reverse().ToArray()))
);

Console.WriteLine(result);
Console.WriteLine("");
