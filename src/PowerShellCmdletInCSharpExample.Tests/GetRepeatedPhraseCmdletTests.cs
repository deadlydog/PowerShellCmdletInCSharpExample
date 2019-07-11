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
					var results = new List<string>();
					var enumerator = cmdlet.Invoke().GetEnumerator();
					while (enumerator.MoveNext())
					{
						var result = enumerator.Current as string;
						results.Add(result);
					}

					// Assert.
					Assert.Equal(results.First(), expectedResult);
				}
			}
		}
	}
}
