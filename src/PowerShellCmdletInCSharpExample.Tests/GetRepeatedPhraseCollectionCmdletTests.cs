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
					var results = new List<string>();
					var enumerator = cmdlet.Invoke().GetEnumerator();
					while (enumerator.MoveNext())
					{
						var result = enumerator.Current as string;
						results.Add(result);
					}

					// Assert.
					Assert.Equal(results, expectedResult);
				}
			}
		}
	}
}
