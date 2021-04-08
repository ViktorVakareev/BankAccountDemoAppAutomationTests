using ConsoleApp1;
using NUnit.Framework;
using System;

namespace TestProject1_LiveDemo
{
    public class Tests
    {
        private string _name;
        [SetUp]
        public void Setup()
        {
            _name = "setup";            
           
        }

        [Test]
        [Category("Medium")]
        public void BankAccountHaveCorrectAmountAfterDeposit()
        {
            var bankAccount = new BankAcount(1000);
            bankAccount.Deposit(200);
            var deposit = bankAccount.Amount;

            Assert.AreEqual(1200, deposit);
        }
        [Test]
        [Category("Critical")]
        public void ExceptionIsThrownWhenNegativeValueForDeposit()
        {
            var bankAccount = new BankAcount(1000);

            //Assert.That(() => { bankAccount.Deposit(-200); },
            //Throws.ArgumentException, "Deposit can not be negative!");

            TestDelegate negatitveAccount = () => new BankAcount(-111);
            Assert.Throws<ArgumentException>(negatitveAccount, "Deposit can not be negative!");
        }
        [Test]
        [Category("Medium")]
        public void WithdrawLessThan1000()
        {
            var bankAccount = new BankAcount(1000);
         
            bankAccount.Withdraw(900);

            Assert.AreEqual(55, bankAccount.Amount);
        }
        [Test]
        [Category("Medium")]
        public void WithdrawMoreThan1000()
        {
            var bankAccount = new BankAcount(1000);
            bankAccount.Deposit(500);

            bankAccount.Withdraw(1200);

            Assert.That(276,Is.EqualTo(bankAccount.Amount));
        }
        [Test]
        [Category("Critical")]
        public void ExceptionIsThrownWhenNegativeValueForAmountAfterWithdraw()
        {
            var bankAccount = new BankAcount(1000);


            Assert.That(() => { bankAccount.Withdraw(1200); },
                
                Throws.ArgumentException, "Amount can not be negative!");

        }       

    }
}