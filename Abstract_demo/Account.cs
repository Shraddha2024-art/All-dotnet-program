namespace Abstract_demo{
    internal abstract class Account{
        public int AccountId { get; set; }
        public Customer cust { get; set; }
 
 
        public Account(int accId, Customer cust)
        {
            AccountId = accId;
            this.cust = cust;
        }
 
        // public override string ToString()
        // {
        //     return $"Account Details: {AccountId} {cust}";
        // }
 
        public void ShowDetails(){
            System.Console.WriteLine($"Account Details: {AccountId} {cust}");
        }
 
        public abstract void ShowBalance();
 
        public override string ToString(){
            return $"{AccountId} {cust}";
        }
 
    }
}