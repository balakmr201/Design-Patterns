using System;
namespace StrategyDesignPattern.StrategyDesign
{
    public class CompressZip :IStrategyAbstract
    {
        public CompressZip()
        {
        }
        public void CompressFile(string FileName)
        {
            Console.WriteLine("Zip file created for File:" + FileName);
        }
    }
}
