﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
	class WeatherData : Subject
	{
		private ArrayList observers;
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData()
		{
			observers = new ArrayList();
		}

		public void registerObserver(Observer o)
		{
			observers.Add(o);
		}

		public void removeObserver(Observer o)
		{
			observers.Remove(o);
		}

		public void notifyObservers()
		{
			for(int i = 0; i < observers.Count; i++)
			{
				Observer observer = (Observer)observers[i];
				observer.update(temperature, humidity, pressure);
			}
		}

		public void measurementsChanged()
		{
			notifyObservers();
		}

		public void setMeasurements(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			measurementsChanged();
		}
	}
}
