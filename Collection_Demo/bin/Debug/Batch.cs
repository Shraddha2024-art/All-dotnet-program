namespace Collection_Demo
{
    internal class Batch:IEmumerable
    {
        public int BatchId {get; set;}
        public Student[] studlist= new Student[6];
        public Batch()
        {
            BatchId =1 ;
            studlist = new Student[6];
            {
                studlist[0] = new Student() {BatchId = 1, nameof = "Bill"};
                studlist[1] = new Student() {BatchId = 2, nameof = "Till"};
                studlist[2] = new Student() {BatchId = 3, nameof = "Sill"};
                studlist[3] = new Student() {BatchId = 4, nameof = "Hill"};
                studlist[4] = new Student() {BatchId = 5, nameof = "Gill"};
                studlist[5] = new Student() {BatchId = 6, nameof = "Mill"};

            }

        }
    }
}