using System;
namespace StrategyDesignPattern.StrategyDesign
{
    public class CompressRar : IStrategyAbstract
    {
        public CompressRar()
        {
        }
        public void CompressFile(string FileName)
        {
            Console.WriteLine("Rar file created for File:" + FileName);
        }
    }
}
