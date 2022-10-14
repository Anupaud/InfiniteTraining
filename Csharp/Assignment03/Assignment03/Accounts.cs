//1.Create a class called Accounts which has data members(fields) like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
//D->Deposit
//W->Withdrawal

//-write a function that updates the balance depending upon the transaction type

//	-If transaction type is deposit call the credit(int amount) function and update balance
//	-If transaction type is withdraw call debit(int amt)function and update balance
//-Pass the other information like Acount no, name, acc type through constructor
//-call the show data method to display the values.

using System;

namespace Assignment03
{
    class Accounts
    {
        
        public int AccountNo;
        public string Customername;
        public string AccountType;
        public char TransactionType;
        public int Amount;
        public int Balance ;
        public char d = 'd';
        public char w = 'w';


        static void Main(string[] args)
        {
            Accounts bank = new Accounts(668877, "sheshadri", "savingsAcc");
            Console.WriteLine("Please enter the transaction Type (d for deposit / w for withdrawal) :");
            bank.TransactionType = Convert.ToChar(Console.ReadLine()); 
            Console.WriteLine("Enter the amount : ");
            bank.Amount = Convert.ToInt32(Console.ReadLine());
            bank.Balance = bank.TransType(bank.Amount, bank.TransactionType);
            Console.WriteLine("After the Transaction the Account Details are : ");
            bank.ShowData();
           Console.ReadKey();
        }

        public Accounts(int accNo, string name, string accType)
        {
            AccountNo = accNo;
            Customername = name;
            AccountType = accType;
        }

        public int TransType(int amt, char transactionType)
        {
            if (transactionType == d)
            {
                Console.WriteLine("Amount Credited into your account : " + amt);
                return AmountCredit(amt);
            }

            else if (transactionType == w)
            {
                Console.WriteLine("Amount Debited from your account: " + amt);
                return AmountDebit(amt);
            }

            else
            {
                Console.WriteLine("Enter valid Transaction Type : ");
                return 0;
            }

        }

        public int AmountCredit(int amountValue)
        {
            Balance = Balance + amountValue;
            return Balance;
        }

        public int AmountDebit(int amountValue)
        {
            Balance = Balance - amountValue;
            return Balance;
        }

        public void ShowData()
        {
            Console.WriteLine("Account No :{0}\nCustomer Name :{1}\nAccount type : {2}\nBalance : {3}", AccountNo, Customername, AccountType, Balance);
        }
    }
}

