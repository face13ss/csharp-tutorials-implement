namespace Clases;

public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(string name, decimal initialBalance): base(name, initialBalance)
    {
        
    }

    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            decimal interest = Balance * 0.02m;
            MakeDeposit(interest, DateTime.Now, "apply monthly interest");
        }
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    => isOverdrawn
    ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
    : default;
}