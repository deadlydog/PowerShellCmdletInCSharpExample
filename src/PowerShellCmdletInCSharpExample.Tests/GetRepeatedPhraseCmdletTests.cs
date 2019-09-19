using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PowerShellCmdletInCSharpExample.Tests
{
	public class GetRepeatedPhraseCmdletTests
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
					var cmdlet = new GetRepeatedPhraseCmdlet()
					{
						Phrase = phrase,
						NumberOfTimesToRepeatPhrase = numberOfTimesToRepeat
					};
					var expectedResult = "A test phrase.A test phrase.A test phrase.";

					// Act.
					var results = cmdlet.Invoke().OfType<string>().ToList();

					// Assert.
					Assert.Equal(results.First(), expectedResult);
					Assert.True(results.Count == 1);
				}
			}
		}
	}
}
