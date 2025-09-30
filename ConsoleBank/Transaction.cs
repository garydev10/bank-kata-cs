using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    internal struct Transaction
    {
        public DateTime TransDate;
        public int Amount;
        public Transaction(DateTime transDate, int amount) 
        {
            this.TransDate = transDate;
            this.Amount = amount;
        }
    }
}
