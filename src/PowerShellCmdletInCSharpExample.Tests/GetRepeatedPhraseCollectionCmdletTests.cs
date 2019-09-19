using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PowerShellCmdletInCSharpExample.Tests
{
	public class GetRepeatedPhraseCollectionCmdletTests
	{
		public class GetRepeatedStringCollection
		{
			public class WhenCalledWithValidParameters
			{
				[Fact]
				public void ShouldReturnThePhraseRepeatedTheCorrectNumberOfTimes()
				{
					// Arrange.
					var phrase = "A test phrase.";
					int numberOfTimesToRepeat = 3;
					var cmdlet = new GetRepeatedPhraseCollectionCmdlet()
					{
						Phrase = phrase,
						NumberOfTimesToRepeatPhrase = numberOfTimesToRepeat
					};
					var expectedResult = Enumerable.Repeat(phrase, numberOfTimesToRepeat);

					// Act.
					var results = cmdlet.Invoke().OfType<string>().ToList();

					// Assert.
					Assert.Equal(results, expectedResult);
				}
			}
		}
	}
}
