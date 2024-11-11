namespace Abstract_demo
{
    internal class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Years { get; set; }
        //defualt Constructor
        public Date()
        {
            Day = 24;
            Month = 2;
            Years = 2000;
        }
        //parameters Constructor
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Years = year;
        }
        public override string ToString()
        {
            return Day + "/" + Month + "/" + Years;
        }
    }
}