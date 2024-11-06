using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Accounts
    {
        Double accountNo;
        String name;
        String accountType;
        static String transactionType;
        Double amount;
        static Double balance;

        public Accounts(Double accountNo, String name, String accountType)
        {
            accountNo = accountNo;
            name = name;
            accountType = accountType;
        }

        public static void TransactionType()
        {
            Credit(1000);
            Debit(730);

        }
        public static void Credit(int Amount)
        {
            balance += Amount;
        }

        public static void Debit(int Amount)
        {
            balance -= Amount;
        }


    }
}
