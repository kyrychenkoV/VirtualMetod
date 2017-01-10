using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodCar
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var car=new Car();
			Factory reference;
			reference = car;

			for (var i = 1; i < 4; i++)
			{
				car.MarkCar = reference.CreateCar(i);
				if (i == 3)
				{	var config=new Configuration();
					reference = config;
					car.Configuration = reference.BasicEquipment()+" "+reference.AdditionalEquipment();
				}
				else
				{
					car.Configuration = reference.BasicEquipment() + "," + reference.AdditionalEquipment();
				}
				Console.WriteLine(car);
				Console.WriteLine();
			}
		}
	}
}
