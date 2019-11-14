using ALMTheo.Models;
using System;
using Xunit;

namespace ALMTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithdrawMoney()
        {

            // arrange
            var bankrepo = new BankRepository();
            var account = bankrepo.GetAccount(1);
            var amount = 100;

            // act
            account.Money -= amount;


            // Assert
            Assert.Equal(0, account.Money);

        }
        [Fact]
        public void TestDepositMoney()
        {

            // arrange
            var bankrepo = new BankRepository();
            var account = bankrepo.GetAccount(1);
            var amount = 100;

            // act
            account.Money += amount;


            // Assert
            Assert.Equal(200, account.Money);

        }
        [Fact]
        public void TestWithdrawTooMuchMoney()
        {
            
            // arrange
            var bankrepo = new BankRepository();
            var amount = 1000;
            var id = 1;



            // act
            var account = bankrepo.TakeMoney(amount, id);


            // Assert
            // Om false så fungerar det
            Assert.False(account);

        }
    }
}
