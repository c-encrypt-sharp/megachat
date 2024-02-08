namespace PPPI_LR2_MODULES
{
    public abstract class StatisticElement
    {
        protected StatisticElement() { }
        public int CountOnline { get; set; } 
        public int TotalCountMessages { get; set; }
        public int AvgMessagesInDay { get; set; }
        public int AvgTimeOnline { get; set; }
    }
}