using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodCar
{
	internal class Car:Factory
	{
		public string Configuration { get; set; }

		public string MarkCar { get; set; }

		public override string ToString()
		{
			 return "Mark car:" + MarkCar + "\n" + "Configurations car:" + Configuration;
		}
		
	}
}
