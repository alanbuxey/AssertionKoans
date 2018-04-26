using AssertionKoans.Engine;

namespace AssertionKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        /*
            This is your path to enlightenment.

            You'll need to complete the steps in each of these classes in order to reach enlightenment.
        */

        public PathToEnlightenment()
        {
	        Types = new[] 
            {
                typeof(BasicAssertions), 
                typeof(StringAssertions),
                typeof(NumericAssertions),
                typeof(DateTimeAssertions),
                typeof(CollectionAssertions),
                typeof(ExceptionAssertions),
                typeof(AdvancedAssertions)
            };
        } 
    }
}