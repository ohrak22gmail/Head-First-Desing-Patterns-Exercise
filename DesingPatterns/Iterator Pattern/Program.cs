﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			PancakeHouseMenu pancakeMenu = new PancakeHouseMenu();
			DinerMenu dinerMenu = new DinerMenu();

			Waitress waitress = new Waitress(pancakeMenu, dinerMenu);

			waitress.printMenu();
		}
	}
}
