// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine($"Hello {System.Environment.GetEnvironmentVariable("USER")}");

if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
{
	Console.WriteLine("We're on Linux!");
}

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
 	Console.WriteLine("We're on Windows!");
}

Console.WriteLine("Version {0}", Environment.OSVersion.Version);

