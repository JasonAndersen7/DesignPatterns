using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LivingroomLightOffCommand : Command
	{
		Light light;

		public LivingroomLightOffCommand(Light light)
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
