using System;
using System.IO;

namespace AdventOfCode2019 {
	public class Day_1_2 {
		public Day_1_2() {
			string[] lines = File.ReadAllLines("inputs/exercise_1_2.txt");

			int total = 0;
			foreach (string line in lines) {
				total += CalcFinalFuelFromMass(int.Parse(line));
			}

			Console.WriteLine("Day 1 - Exercise 2: " + total);
		}

		public static int CalcFinalFuelFromMass(int mass) {
			int newMass = mass;
			int fuelCost = 0;

			while ((newMass = Day_1_1.CalcFuelFromMass(newMass)) > 0) {
				fuelCost += newMass;
			}

			return fuelCost;
		}
	}
}
