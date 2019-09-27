using System;

namespace BMIcalcualtor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.ReadLine();
			Console.WriteLine("What is Your name?");
			string firstName;
			string lastName;
			Console.WriteLine("Enter Your first name: ");
			firstName = Console.ReadLine();
			Console.WriteLine("Enter Your last name: ");
			lastName = Console.ReadLine();
			Console.WriteLine("Hello," + firstName + " " + lastName + "!");

			Console.WriteLine("How old are You?");
			int userAge;
			userAge = Int32.Parse(Console.ReadLine());

			if (userAge > 20 && userAge < 65)
			{
				Console.WriteLine("Congratulations, Your age is appropriate for calculating your body mass index");
				Console.WriteLine("Enter Your height in meters: ");
				double userHeight;
				userHeight = Double.Parse(Console.ReadLine());

				Console.WriteLine("Enter Your weight in kgs: ");
				double userWeight;
				userWeight = Double.Parse(Console.ReadLine());
				Console.WriteLine($"Height {userHeight}");

				double BMI;
				BMI = userWeight / (userHeight * userHeight);
				Console.WriteLine(BMI);

				if (BMI < 16)
				{
					Console.WriteLine("Unhealthy underweight");
				}

				else if (BMI > 16 && BMI <= 18.5)
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Underweight");
				}

				else if (BMI > 18.6 && BMI <= 25)
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Normal weight");
				}
				else if (BMI > 25.1 && BMI <= 30)
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Overweight");
				}
				else if (BMI > 30.1 && BMI <= 35)
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Obesity");
				}
				else if (BMI > 35.1 && BMI <= 40)
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Severe obesity");
				}
				else
				{
					Console.WriteLine(Math.Round(BMI, 1));
					Console.WriteLine("Unhealthy obesity");
				}
			}
			else
			{
				if (userAge < 20)
				{
					Console.WriteLine("Sorry, You are too young!");
				}
				else
				{
					Console.WriteLine("Sorry, You are too old!");
				}

			}

			Console.ReadLine();
		}

	}

}


			
		