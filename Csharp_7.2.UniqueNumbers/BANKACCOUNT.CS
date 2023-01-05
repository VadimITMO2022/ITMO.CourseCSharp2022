
class BankAccount 
{
  //  public void Populate(long number, decimal balance)
    public void Populate(decimal balance)
    {
    //    accNo = number;
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;

  //      int nextAccNo = 10;
    }
    
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
    
    private static long nextNumber = 123;
    private static long NextNumber()
    {
      
        return nextNumber++;
    }


    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo;
}
