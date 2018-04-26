using System.Collections.Generic;
using AssertionKoans.Engine;
using FluentAssertions;

namespace AssertionKoans.Koans
{
	class CollectionAssertions : Koan
	{
        /*
            There's some great things you can do with collection assertions.

            We also introduce chaining multiple assertions here,
                though this isn't just limited to collections.
        */

        class TestObject
        {
            public int IntValue { get; set; }
            public string StringValue { get; set; }
        }

		[Step(1)]
		public void CollectionShouldBeEmpty()
		{
			var array = new int[] { 0 };
            array.Should().BeEmpty();
		}

        [Step(2)]
        public void SimpleEquality()
        {
            var item = new TestObject { IntValue = 1 };
            var first = new [] { item };
            var second = new [] { item };

           first.Should().Equal(second); // Reference equality
        }

        [Step(3)]
        public void SimpleEquivalence()
        {
            var first = new [] { new TestObject { IntValue = 1 } };
            var second = new [] { new TestObject { IntValue = 1 } };

            first.Should().BeEquivalentTo(FILL_ME_IN); // Equivalence comparison
        }

        [Step(4)]
        public void Ordering()
        {
            var descendingCollection = new [] { 5, 4, 3, 2, 1 };

            descendingCollection.Should().BeInAscendingOrder();
        }

        [Step(5)]
        public void ChainedAssertions()
        {
            var collection = new object [] {  }; // Make a collection that meets the criteria

            // You can chain assertions on a collection like this...
            collection.Should()
                .HaveCount(5)
                .And.ContainItemsAssignableTo<int>()
                .And.OnlyHaveUniqueItems()
                .And.Contain(2)
                .And.EndWith(11)
                .And.NotContain(x => ((int) x) < 0);
        }

        [Step(6)]
        public void PropertyAssertions()
        {
            var collection = new TestObject [] { };

            collection.Should()
                .HaveCount(3)
                .And.NotContainNulls()
                .And.OnlyHaveUniqueItems(x => x.IntValue)
                .And.OnlyContain(x => !string.IsNullOrWhiteSpace(x.StringValue) && x.StringValue.Length > 5);
        }

        [Step(7)]
        public void DictionaryAssertions()
        {
            var dictionary = new Dictionary<string, int>();

            dictionary.Should()
                .HaveCount(4)
                .And.ContainKey("Badger")
                .And.ContainValue(7)
                .And.Contain("Mushroom", 4)
                .And.Contain(new KeyValuePair<string, int>("Snake", 2))
                .And.NotContainKeys(null, string.Empty, " ");
        }
    }
}