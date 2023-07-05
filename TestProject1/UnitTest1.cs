using Xunit;
using Lab02;

namespace Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance_ShouldReturnCurrentBalance()
        {
            // Arrange
            Program.Balance = 100;

            // Act
            decimal balance = Program.ViewBalance();

            // Assert
            Assert.Equal(100, balance);
        }

        [Fact]
        public void Withdraw_ValidAmount_ShouldDeductFromBalance()
        {
            // Arrange
            Program.Balance = 100;
            decimal withdrawAmount = 50;

            // Act
            Program.Withdraw(withdrawAmount);

            // Assert
            Assert.Equal(50, Program.Balance);
        }

        [Fact]
        public void Withdraw_InsufficientFunds_ShouldNotDeductFromBalance()
        {
            // Arrange
            Program.Balance = 100;
            decimal withdrawAmount = 150;

            // Act
            Program.Withdraw(withdrawAmount);

            // Assert
            Assert.Equal(100, Program.Balance);
        }

        [Fact]
        public void Withdraw_NegativeAmount_ShouldNotDeductFromBalance()
        {
            // Arrange
            Program.Balance = 100;
            decimal withdrawAmount = -50;

            // Act
            Program.Withdraw(withdrawAmount);

            // Assert
            Assert.Equal(100, Program.Balance);
        }

        [Fact]
        public void Deposit_ValidAmount_ShouldAddToBalance()
        {
            // Arrange
            Program.Balance = 100;
            decimal depositAmount = 50;

            // Act
            Program.Deposit(depositAmount);

            // Assert
            Assert.Equal(150, Program.Balance);
        }

        [Fact]
        public void Deposit_NegativeAmount_ShouldNotAddToBalance()
        {
            // Arrange
            Program.Balance = 100;
            decimal depositAmount = -50;

            // Act
            Program.Deposit(depositAmount);

            // Assert
            Assert.Equal(100, Program.Balance);
        }
    }
}
