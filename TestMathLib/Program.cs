
using MathLibrary;
using StringLib;

Console.WriteLine(MathLib.About);

Console.WriteLine($"Inverse: {AlgebraClass.Inverse(12)}");
Console.WriteLine($"Modulo: {AlgebraClass.Modulo(12,5)}");
Console.WriteLine($"Cubed: {AlgebraClass.Cubed(3)}");

Console.WriteLine($"Rotate:{StringClass.Rotate("abcd")}");
Console.WriteLine($"Reverse: {StringClass.Reverse("abcd")}");
Console.WriteLine($"Remove Vowels: {StringClass.RemoveVowels("abcdefg")}");