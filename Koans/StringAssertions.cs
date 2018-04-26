using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class StringAssertions : Koan
	{
        /*
            This looks at some of the basic assertions you might use for strings.

			Again, there's some comparison between Fluent Assertions and Should Extensions.
        */

		[Step(1)]
		public void StringContainsUsingUnidaysShould()
		{
			"hello world".ShouldContain("badger");
		}

		[Step(2)]
		public void StringContainsUsingFluentAssertions()
		{
			"hello world".Should().Contain("badger");
		}

		[Step(3)]
		public void StringStartsAndEndsWithUsingUnidaysShould()
		{
			var message = "hello world";
			message.ShouldStartWith("goodbye");
			message.ShouldEndWith("badger");
		}

		[Step(4)]
		public void StringStartsAndEndsWithUsingFluentAssertions()
		{
			var message = "hello world";
			message.Should().StartWith("goodbye").And.EndWith("badger");
		}

		[Step(5)]
		public void IgnoringCaseWithUsingUnidaysShould()
		{
			"HELLO world".ShouldBeEqualIgnoringCase("goodbye badger");
		}

		[Step(6)]
		public void IgnoringCaseWithUsingFluentAssertions()
		{
			"HELLO world".Should().BeEquivalentTo("goodbye badger");
		}

		[Step(7)]
		public void LengthWithUsingUnidaysShould()
		{
			"Hello!".Length.ShouldEqual(5);
		}

		[Step(8)]
		public void LengthWithUsingFluentAssertions()
		{
			"Hello!".Should().HaveLength(5);
		}
	}
}