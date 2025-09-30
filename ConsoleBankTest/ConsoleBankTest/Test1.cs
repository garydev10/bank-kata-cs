using ConsoleBank;

namespace ConsoleBankTest
{
    [TestClass]
    public sealed class Test1
    {
        private const string Expected = @"Date       || Amount || Balance
14/01/2012 || -500   || 2500
13/01/2012 || 2000   || 3000
10/01/2012 || 1000   || 1000";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                //Given a client makes a deposit of 1000 on 10-01-2012
                //And a deposit of 2000 on 13-01-2012
                //And a withdrawal of 500 on 14-01-2012
                Account account = new Account();
                account.SetTransactionDate("10-01-2012");
                account.deposit(1000);
                account.SetTransactionDate("13-01-2012");
                account.deposit(2000);
                account.SetTransactionDate("14-01-2012");
                account.withdraw(500);
                account.printStatement();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
