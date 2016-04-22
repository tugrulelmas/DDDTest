using DDDTest.Logic;
using FluentAssertions;
using NUnit.Framework;

namespace DDDTest.UnitTests
{
    public class MoneySpecs
    {
        [Test]
        public void Sum_of_two_moneys_produces_correct_result() {
            Money money1 = new Money(1, 2, 3, 4, 5, 6);
            Money money2 = new Money(1, 2, 3, 4, 5, 6);

            var sum = money1 + money2;
            sum.OneCentCount.Should().Be(2);
        }

        [Test]
        public void Are_two_money_equal() {
            Money money1 = new Money(1, 2, 3, 4, 5, 6);
            Money money2 = new Money(1, 2, 3, 4, 5, 6);

            money1.Should().Be(money2);
        }
    }
}
