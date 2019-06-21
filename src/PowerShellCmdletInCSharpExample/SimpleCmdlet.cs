using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace PowerShellCmdletInCSharpExample
{
	[Cmdlet(VerbsCommon.Get, "RepeatedString")]
	[OutputType(typeof(string))]
	public class GetRepeatedStringCmdlet : Cmdlet
	{
		[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Word")]
		[ValidateNotNullOrEmpty()]
		public string Phrase { get; set; }

		[Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Repeat")]
		public int NumberOfTimesToRepeatString { get; set; }

		protected override void ProcessRecord()
		{
			base.ProcessRecord();

			var result = new StringBuilder();
			for (int i = 0; i < NumberOfTimesToRepeatString; i++)
			{
				result.Append(Phrase);
			}

			WriteObject(result.ToString());
		}
	}

	[Cmdlet(VerbsCommon.Get, "RepeatedStringCollection")]
	[OutputType(typeof(IEnumerable<string>))]
	public class GetRepeatedStringCollectionCmdlet : Cmdlet
	{
		[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Word")]
		[ValidateNotNullOrEmpty()]
		public string Phrase { get; set; }

		[Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
		[Alias("Repeat")]
		public int NumberOfTimesToRepeatString { get; set; }

		protected override void ProcessRecord()
		{
			base.ProcessRecord();

			var results = new List<string>();
			for (int i = 0; i < NumberOfTimesToRepeatString; i++)
			{
				results.Add(Phrase);
			}

			WriteObject(results, true);
		}
	}
}
