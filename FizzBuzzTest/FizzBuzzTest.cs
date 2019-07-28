using FizzBuzzTest;
using NUnit.Framework;
using Shouldly;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ItShouldSayFizzWhenEnter3()
        {
            Given.AFizzBuzz.Say(3).ShouldBe("Fizz");
        }

        [Test]
        public void ItShouldSayBuzzWhenEnter5()
        {
            Given.AFizzBuzz.Say(5).ShouldBe("Buzz");
        }

        [Test]
        public void ItShouldSayFizzBuzzWhenEnter15()
        {
            Given.AFizzBuzz.Say(15).ShouldBe("FizzBuzz");
        }

        [Test]
        public void ItShouldSay16WhenEnter16()
        {
            Given.AFizzBuzz.Say(16).ShouldBe("16");
        }
    }
}