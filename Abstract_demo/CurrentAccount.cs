namespace Abstract_demo{
    internal class CurrentAccount:Account{
        public float InterestRate { get; set; }
        public decimal Balance { get; set; }
       
        // public CurrentAccount(){
        //     InterestRate = 8.5f;
 
        // }
 
        public CurrentAccount(float intRate, decimal balance,int accId, Customer cust):base(accId,cust){
            InterestRate = intRate;
            Balance = balance;
        }
 
        public override void ShowBalance(){
            System.Console.WriteLine($"Current Account Balance: {Balance:c}");
        }
 
        public override string ToString(){
            return $"Current Account Details: {AccountId} {InterestRate} {Balance:c} {base.ToString()}";
        }
    }
}