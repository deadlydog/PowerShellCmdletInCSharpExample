using System.Collections.Generic;
using System.Management.Automation;

namespace PowerShellCmdletInCSharpExample
{
	[Cmdlet(VerbsCommon.Get, "RepeatedPhraseCollection")]
	[OutputType(typeof(IEnumerable<string>))]
	public class GetRepeatedPhraseCollectionCmdlet : Cmdlet
	{
		[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Word")]
		[ValidateNotNullOrEmpty()]
		public string Phrase { get; set; }

		[Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Repeat")]
		public int NumberOfTimesToRepeatPhrase { get; set; }

		protected override void ProcessRecord()
		{
			base.ProcessRecord();

			var results = new List<string>();
			for (int i = 0; i < NumberOfTimesToRepeatPhrase; i++)
			{
				results.Add(Phrase);
			}

			WriteObject(results, true);
		}
	}
}
