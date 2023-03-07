namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double withdrawAmount)
        {
            return _money -= withdrawAmount;
        }

        public void Deposit(double depositAmount)
        {
            _money += depositAmount;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money:N}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
