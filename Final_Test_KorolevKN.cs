string[] list = { "2", "1567", "-2", "computer science", ":-)", "Greg", "want", "to", "Mars" };

var newList = new List<string>();

for (int i = 0; i < list.Length; i++)
{
    if (list[i].Length <= 3)
    {
        newList.Add(list[i]);
    }
}