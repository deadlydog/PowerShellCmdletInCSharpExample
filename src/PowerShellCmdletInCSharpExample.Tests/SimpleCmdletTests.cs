using System;
using System.Linq;
using Xunit;

namespace PowerShellCmdletInCSharpExample.Tests
{
	public class SimpleCmdletTests
	{
		public class GetRepeatedString
		{
			public class WhenCalledWithValidParameters
			{
				[Fact]
				public void ShouldReturnThePhraseRepeatedTheCorrectNumberOfTimes()
				{
					// Arrange.
					var phrase = "A test phrase.";
					int numberOfTimesToRepeat = 3;
					var cmdlet = new GetRepeatedStringCmdlet()
					{
						Phrase = phrase,
						NumberOfTimesToRepeatPhrase = numberOfTimesToRepeat
					};
					var expectedResult = Enumerable.Repeat(phrase, numberOfTimesToRepeat);

					// Act.
					var enumerator = cmdlet.Invoke().GetEnumerator();
					Assert.True(enumerator.MoveNext());
					var results = enumerator.Current;

					// Assert.
					Assert.Equal(results, expectedResult);
				}
			}
		}
	}
}
