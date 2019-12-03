using System;
using System.IO;

namespace AdventOfCode2019 {
	public class Day_1_1 {
		public Day_1_1() {
			string[] lines = File.ReadAllLines("exercise_1_1.txt");

			int total = 0;
			foreach (string line in lines) {
				total += Day_1_1.CalcFuelFromMass(int.Parse(line));
			}

			Console.WriteLine(total);
		}

		public static int CalcFuelFromMass(int mass) {
			return (int)(
				Math.Floor(mass / 3.0f)
				- 2.0
			);
		}
	}
}
