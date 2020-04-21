using System;
using System.Management;
namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Версия Windows: "+ Environment.OSVersion);
            Console.WriteLine("64 Bit операционная система? : "+ Environment.Is64BitOperatingSystem);
            Console.WriteLine("Имя компьютера : "+Environment.MachineName);
            Console.WriteLine("Число процессоров : " + Environment.ProcessorCount);
            Console.WriteLine("Системная папка : "+Environment.SystemDirectory);
            Console.ReadKey();
        }
    }
}
