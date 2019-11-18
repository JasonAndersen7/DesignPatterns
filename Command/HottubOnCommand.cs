using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for HottubOnCommand.
	/// </summary>
	public class HottubOnCommand : Command
	{
		Hottub hottub;

		public HottubOnCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		#region Command Members
		public object Execute()
		{
			return hottub.On() +
				"\n" + hottub.Heat() +
				"\n" + hottub.BubblesOn();
		}
		#endregion
	}
}
