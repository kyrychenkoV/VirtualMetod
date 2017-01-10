using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodCar
{
	internal class Configuration:Car
	{
		public override string AdditionalEquipment()
		{
			return ",signaling,,heated seats,cruise control";
		}
	}
}
