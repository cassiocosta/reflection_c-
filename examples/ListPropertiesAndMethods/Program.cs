using System.Reflection;
using ListPropertiesAndMethods;

Type type = typeof(Car);

Console.WriteLine("Properties:");
foreach (var prop in type.GetProperties())
{
    Console.WriteLine($"- {prop.Name} ({prop.PropertyType})");
}

Console.WriteLine("\nMethods:");
foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
{
    Console.WriteLine($"- {method.Name}");
}