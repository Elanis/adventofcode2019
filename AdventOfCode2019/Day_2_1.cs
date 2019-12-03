using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019 {
	public class Day_2_1 {
		public Day_2_1() {
			string program = File.ReadAllText("inputs/exercise_2_1.txt");

			List<int> operands = program.Split(',').Select((elt) => int.Parse(elt)).ToList();

			operands[1] = 12;
			operands[2] = 2;

			program = String.Join(",", operands.ToArray());

			string result = ComputeProgram(program);

			Console.WriteLine("Day 2 - Exercise 1: " + result);
		}

		public static string ComputeProgram(string program) {
			List<int> operands = program.Split(',').Select((elt) => int.Parse(elt)).ToList();

			for (int i = 0; i < operands.Count(); i += 4) {
				if (operands[i] == 99) {
					break;
				} else if (operands[i] == 1) {
					operands[operands[i + 3]] = operands[operands[i + 1]] + operands[operands[i + 2]];
				} else if (operands[i] == 2) {
					operands[operands[i + 3]] = operands[operands[i + 1]] * operands[operands[i + 2]];
				}
			}

			return String.Join(",", operands.ToArray());
		}
	}
}
