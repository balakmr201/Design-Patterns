using System;
using StrategyDesignPattern.StrategyDesign;

namespace StrategyDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern Example");
            CompressContext compressContext = new CompressContext(new CompressZip());

            compressContext.CreateArchive("File1");

            compressContext.setCompressMethod(new CompressRar());
            compressContext.CreateArchive("File2");

            Console.Read();

        }
    }
}
