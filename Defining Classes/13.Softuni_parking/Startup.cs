using SoftUniParking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
	public class Parking
	{
		private List<Car> cars;
		private int capacity;

		public Parking(int capacity)
		{
			cars = new List<Car>();
			this.capacity = capacity;
		}

		public int Count => this.cars.Count;

		public string AddCar(Car car)
		{
			if (this.cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
			{
				return "Car with that registration number, already exists!";
			}
			if (this.cars.Count() + 1 > this.capacity)
			{
				return "Parking is full!";
			}
			this.cars.Add(car);
			return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
		}

		public string RemoveCar(string registrationNumber)
		{
			if (!this.cars.Any(x => x.RegistrationNumber == registrationNumber))
			{
				return "Car with that registration number, doesn't exist!";
			}
			else
			{
				Car carToRemove = this.cars.Where(x => x.RegistrationNumber == registrationNumber).First();
				this.cars.Remove(carToRemove);
				return $"Successfully removed {registrationNumber}";
			}
		}

		public Car GetCar(string registrationNumber)
		{
			Car carToGet = this.cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);  //same
			return carToGet;
		}

		public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
		{
			this.cars = cars.Where(c => !RegistrationNumbers.Contains(c.RegistrationNumber)).ToList();  // same
		}
	}
}
