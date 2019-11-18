using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LightOnCommand : Command
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.On();
		}

		#endregion
	}
}
