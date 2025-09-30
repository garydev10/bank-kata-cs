namespace ConsoleBank
{
    public class Account : IAccountService
    {
        private readonly string _headerString = "Date       || Amount || Balance";
        private readonly string _inputDateFormat = "dd-MM-yyyy";
        private DateTime _transactionDate = new DateTime();
        private List<Transaction> _transactions = new List<Transaction>();
        public void SetTransactionDate(string ddmmyyyy)
        {
            _transactionDate = DateTime.ParseExact(ddmmyyyy, _inputDateFormat, null);
        }
        public void deposit(int amount)
        {
            _transactions.Add(new Transaction(_transactionDate, amount));
        }
        public void withdraw(int amount)
        {
            _transactions.Add(new Transaction(_transactionDate, -amount));
        }
        public void printStatement()
        {
            System.Console.WriteLine(printStatementText());
        }
        private string printStatementText()
        {
            // lazy balance evaluation and printing
            int balance = 0;
            var transactionStrings = new List<string>();
            foreach (var transaction in _transactions)
            {
                balance += transaction.Amount;
                transactionStrings.Add($"{transaction.TransDate.ToString("dd/MM/yyyy")} || {transaction.Amount}   || {balance}");
            }
            transactionStrings.Add(_headerString);
            transactionStrings.Reverse();
            return string.Join(Environment.NewLine, transactionStrings);
        }
    }
}
