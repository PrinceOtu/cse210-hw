
public class Account
{
    public int _balance = 0;

    public void Deposit(int amount)
    {
        _balance = _balance + amount;
    }
}

public class Account
{
    public List<int> _transactions = new List<int>(); // if we change this to a list...

    public void Deposit(int amount)
    {
        transactions.Add(amount);
    }
}

public class Account
{
    private List<int> _transactions = new List<int>(); 

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
}