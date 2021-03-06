using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for HottubOnCommand.
	/// </summary>
	public class HottubOffCommand : Command
	{
		Hottub hottub;

		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		#region Command Members
		public object Execute()
		{
			return hottub.Off();
		}
		#endregion
	}
}
