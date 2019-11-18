using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for SimpleRemoteControl
	/// </summary>
	public class SimpleRemoteControl
	{
		Command slot;

		public SimpleRemoteControl()
		{}

		public object SetCommand(Command command)
		{
			slot = command;
			return slot;
		}

		public object ButtonWasPressed()
		{
			return slot.Execute();
		}
	}
}
