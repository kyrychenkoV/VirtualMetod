using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodCar
{
	internal class Factory
	{
		public virtual string CreateCar(int number)
		{
			switch (number)
			{
				case 1:return "Opel";
				case 2: return "Mazda";
				case 3: return "BMW";
				default:break;
			}
			return "Input correct number";
		}
		public virtual string BasicEquipment()
		{
			return "tripTronic,boardComputer,fogLights";
		}
		public virtual string AdditionalEquipment() 
		{
			return "signaling";
		}
		
	}
}
