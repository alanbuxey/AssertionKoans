using System;
using AssertionKoans.Engine;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace AssertionKoans.Koans
{
	class AdvancedAssertions : Koan
	{
		/*
			There's loads of stuff you can do with object equivalence.

			Here's a few ideas summarised in one step, there's more in the docs!
		*/

		class TestObject
		{
			public int IntValue { get; set; }
			public string StringValue { get; set; }

			public float FloatValue => 3.14f;
		}

		[Step(1)]
		public void ObjectEquivalence()
		{
			var thing = new TestObject { };
  
			thing.Should()
				.BeOfType<TestObject>()
				.And.BeEquivalentTo(new
				{
					IntValue = 5,
					StringValue = "hello",
					DateValue = 10.January(1986) // You'll need to add this property
					// The float value doesn't matter
				});
		}
    }
}