using System.Threading.Tasks;
namespace DelegateEvent
{
    delegate void Marked();
    internal class Student
    {
        public int Id {get; set;}        
        public string Name {get; set;}
        public int Marks {get; set;}

        public event Marked Pass;
        public event Marked Fail;



        public void EnterMarks(int m)
        {
            if(m>=50)
            {
                Pass();
            }
            else
            {
                Fail();
            }
        }



    }
}