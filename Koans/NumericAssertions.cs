using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class NumericAssertions : Koan
	{
        /*
            This looks at some of the basic assertions you might use for numbers.

			Again, there's some comparison between Fluent Assertions and Should Extensions.
        */

        [Step(1)]
        public void GreaterThanComparisonUsingUnidaysShould()
        {
            (-1).ShouldBeGreaterThan(0);
        }

        [Step(2)]
        public void GreaterThanUsingFluentAssertions()
        {
            // also has less than equivalent
            (-1).Should().BeGreaterThan(0);
        }

        /*
            You've probably got the idea now!

            Fluent Assertions does all the basics and has great failure messages.

            Let's look at a couple more things we can do with numbers
                before we move on to the cool stuff!
        */

        [Step(3)]
        public void GreaterThanOrEqualUsingFluentAssertions()
        {
            // also has less than equivalent
            (-1).Should().BeGreaterOrEqualTo(1);
        }

        [Step(4)]
        public void BePositiveUsingFluentAssertions()
        {
            // also has negative equivalent            
            (-1).Should().BePositive();
        }

        [Step(5)]
        public void RangeComparison()
        {
            12.Should().BeInRange(1, 10);
        }

        [Step(6)]
        public void Approximately()
        {
            3.145F.Should().BeApproximately(3.14159F, 0.0005F);
        }
	}
}