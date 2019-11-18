using System;

namespace DesignPatterns.Command
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LivingroomLightOnCommand : Command
	{
		Light light;

		public LivingroomLightOnCommand(Light light)
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
