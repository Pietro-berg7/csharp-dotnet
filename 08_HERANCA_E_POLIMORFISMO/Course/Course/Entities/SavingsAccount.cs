namespace Course.Entities
{
    internal class SavingsAccount: Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
