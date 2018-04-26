using System;
using AssertionKoans.Engine;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class ExceptionAssertions : Koan
	{
        /*
            Verifying exceptions can be hard and often the syntax for doing so isn't very nice,
                here's a couple of things you can do with Fluent to help with that.

            Look at the two different syntaxes for verifying the exception
                and then modify the methods to throw the right kind.
        */

        class Stub
        {
            public void TestMethod()
            {
                // This should throw an exception
            }

            public static void StaticMethod()
            {
                // This should throw an exception
            }
        }

        [Step(1)]
        public void ExceptionAssertionsAreReallyEasy()
        {
            // Doing it like this is easy!
            var stub = new Stub();

            stub.Invoking(x => x.TestMethod())
                .Should().Throw<ArgumentException>()
                .WithMessage("Unhelpful error message.")
                .WithInnerException<ArgumentNullException>()
                .Where(x => x.ParamName == "alsoUnhelpful");
        }

        [Step(2)]
        public void StaticMethodsAreHarder()
        {
            // Obviously the Invoking extension won't help you in some cases...
            // Here's an alternative for when you need it.
            Action action = () => Stub.StaticMethod();

            action.Should()
                .Throw<InvalidOperationException>()
                .Where(x => x.Message.StartsWith("Bang."));

            // This is also necessary when testing a constructor.
        }
    }
}