using System;
namespace StrategyDesignPattern.StrategyDesign
{
    public class CompressContext
    {
        private IStrategyAbstract _strategyAbstract;
        public CompressContext(IStrategyAbstract strategyAbstract)
        {
            _strategyAbstract = strategyAbstract;
        }
        public void setCompressMethod(IStrategyAbstract strategyAbstract)
        {
            this._strategyAbstract = strategyAbstract;
        }
        public void CreateArchive(string FileName)
        {
            this._strategyAbstract.CompressFile(FileName);
        }
    }
}
