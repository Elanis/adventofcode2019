using System;
using System.IO;

namespace AdventOfCode2019 {
	public class Day_1_1 {
		public Day_1_1() {
			string[] lines = File.ReadAllLines("inputs/exercise_1_1.txt");

			int total = 0;
			foreach (string line in lines) {
				total += CalcFuelFromMass(int.Parse(line));
			}

			Console.WriteLine("Day 1 - Exercise 1: " + total);
		}

		public static int CalcFuelFromMass(int mass) {
			return (int)(
				Math.Floor(mass / 3.0f)
				- 2.0
			);
		}
	}
}
