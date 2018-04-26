using System;
using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
    class BasicAssertions : Koan
    {
        /*
            This is an introduction to the basic assertions of Fluent Assertions
                as well as a comparison between it and the Should Extensions.

            Making the tests pass is easy, that's not the point here.
            Have a look at what happens when the test fails
                and think about what is helpful in a failure message.

            Once you're happy with a step, you can change the left hand side
                to make the test pass and move on to the next step.
        */

        [Step(1)]
        public void BasicAssertionUsingUnidaysShould()
        {
            // observe failure message, nice and clear right?
            "hellllo".ShouldEqual("hello");
        }

        [Step(2)]
        public void BasicAssertionUsingFluentAssertions()
        {
            // how does the error message compare with the previous step?
            "hellllo".Should().Be("hello");
        }

        [Step(3)]
        public void TrueAssertionUsingUnidaysShould()
        {
            // what is wrong with this failure message?
            (1 == 2).ShouldBeTrue();
        }

        [Step(4)]
        public void TrueAssertionUsingFluentAssertions()
        {
            // what is better about this failure message?
            (1 == 2).Should().BeTrue();
        }

        [Step(5)]
        public void NotNullAssertionUsingUnidaysShould()
        {
            string b = null;

            // does this say what is null in the error?
            b.ShouldNotBeNull();
        }

        [Step(6)]
        public void NotNullAssertionUsingFluentAssertions()
        {
            string b = null;

            // is this clearer?
            b.Should().NotBeNull();
        }

        [Step(7)]
        public void NullAssertionUsingUnidaysShould()
        {
            var b = "hello";

            // this is not a terrible failure message
            b.ShouldBeNull();
        }

        [Step(8)]
        public void NullAssertionUsingFluentAssertions()
        {
            var b = "hello";

            // this gives the same info, but is a little bit more succinct
            b.Should().BeNull();
        }
    }
}
