Console.WriteLine($"sbyte   uses {sizeof(sbyte)} byte(s) and ranges from {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"byte    uses {sizeof(byte)} byte(s) and ranges from {byte.MinValue} to {byte.MaxValue}");

Console.WriteLine($"short   uses {sizeof(short)} byte(s) and ranges from {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"ushort  uses {sizeof(ushort)} byte(s) and ranges from {ushort.MinValue} to {ushort.MaxValue}");

Console.WriteLine($"int     uses {sizeof(int)} byte(s) and ranges from {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"uint    uses {sizeof(uint)} byte(s) and ranges from {uint.MinValue:N0} to {uint.MaxValue:N0}");

Console.WriteLine($"long    uses {sizeof(long)} byte(s) and ranges from {long.MinValue:N0} to {long.MaxValue:N0}");
Console.WriteLine($"ulong   uses {sizeof(ulong)} byte(s) and ranges from {ulong.MinValue:N0} to {ulong.MaxValue:N0}");

unsafe
{
    Console.WriteLine($"Int128  uses {sizeof(Int128)} byte(s) and ranges from {Int128.MinValue:N0} to {Int128.MaxValue:N0}");
    Console.WriteLine($"UInt128 uses {sizeof(UInt128)} byte(s) and ranges from {UInt128.MinValue:N0} to {UInt128.MaxValue:N0}");
    Console.WriteLine($"Half    uses {sizeof(Half)} byte(s) and ranges from {Half.MinValue:N0} to {Half.MaxValue:N0}");
}

Console.WriteLine($"float   uses {sizeof(float)} byte(s) and ranges from {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double  uses {sizeof(double)} byte(s) and ranges from {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal uses {sizeof(decimal)} byte(s) and ranges from {decimal.MinValue:N0} to {decimal.MaxValue:N0}");