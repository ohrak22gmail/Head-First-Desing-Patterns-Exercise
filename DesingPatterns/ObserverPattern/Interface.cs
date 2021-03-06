﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
	interface Subject
	{
		void registerObserver(Observer o);
		void removeObserver(Observer o);
		void notifyObservers();
	}

	interface Observer
	{
		void update(float temp, float humidity, float pressure);
	}

	interface DisplayElement
	{
		void display();
	}
}
