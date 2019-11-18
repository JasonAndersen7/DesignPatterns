using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LightOffCommand : Command
	{
		Light light;

		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.Off();
		}

		#endregion
	}
}
