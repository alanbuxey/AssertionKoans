using System;
using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace AssertionKoans.Koans
{
	class DateTimeAssertions : Koan
	{
        /*
            Fluent has a whole bunch of things you can do with DateTime and TimeSpan,
                it even has a funky way of representing DateTimes!

            Here's some of the stuff you're likely to use,
                there's more in the docs if you're interested.
        */

        [Step(1)]
        public void FancyDateTimeExpression()
        {
            var dateTime = new DateTime(2018, 03, 07, 19, 30, 00, DateTimeKind.Utc);

            // A fluent way of writing DateTimes in tests
            // Hopefully a lot clearer than the DateTime constructor!
            var expected = 7.March(2018).At(19, 30, 25).AsUtc();

            dateTime.Should().Be(expected);
        }

        [Step(2)]
        public void BeBefore()
        {
            // also has after equivalent
            2.March(2018).Should().BeBefore(1.March(2018));
        }

	    [Step(3)]
	    public void HaveProperties()
	    {
		    var dateTime = new DateTime(2018, 10, 1);
		    dateTime.Should().HaveYear(2019).And.HaveMonth(11).And.HaveDay(2);
		}

        [Step(4)]
        public void RangeComparison()
        {            
            2.March(2018).Should().BeLessThan(2.Days()).Before(4.March(2018));
            2.March(2018).Should().BeWithin(2.Days()).Before(5.March(2018));
            2.March(2018).Should().BeMoreThan(2.Days()).After(2.March(2018));
        }

        [Step(5)]
        public void CloseTo()
        {
            // Sometimes it's handy to have some leniancy on DateTimes in tests
            // Particularly if you've got something that hits the database!

            var firstDate = new DateTime(2018, 03, 07, 19, 00, 00);
            var secondDate = new DateTime(2018, 03, 07, 19, 30, 25);

            secondDate.Should().BeCloseTo(firstDate, 30.Minutes());

            // Okay so 30 minutes might be an extreme example, but you could do ms too!

            var thirdDate = new DateTime(2018, 03, 07, 19, 00, 00).AddMilliseconds(4);

            firstDate.Should().BeCloseTo(firstDate, FILL_ME_IN.Milliseconds()); // Change FILL_ME_IN to make this pass
        }
	}
}