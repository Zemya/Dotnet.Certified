
Console.WriteLine("");

string[] pallets = ["B14", "A11", "B12", "A13"];
//PUT IN ORDER
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{

    Console.WriteLine($"-- {pallet}");

}
Console.WriteLine("");
// REVERSE ORDER
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");