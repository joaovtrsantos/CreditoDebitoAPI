using Domain.Entities;

namespace Tests.Domain.Entities
{
    public class CreditDebitTests
    {
        [Fact]
        public void SettingNegativeValue_ShouldThrowArgumentException()
        {
            var creditDebit = new CreditDebit();
            Assert.Throws<ArgumentException>(() => creditDebit.Value = -1);
        }

        [Fact]
        public void SettingZeroValue_ShouldThrowArgumentException()
        {
            var creditDebit = new CreditDebit();
            Assert.Throws<ArgumentException>(() => creditDebit.Value = 0);
        }

        [Fact]
        public void SettingValidValue_ShouldNotThrowException()
        {
            var creditDebit = new CreditDebit();
            decimal validValue = 100;
            creditDebit.Value = validValue;

            Assert.Equal(validValue, creditDebit.Value);
        }
    }
}
