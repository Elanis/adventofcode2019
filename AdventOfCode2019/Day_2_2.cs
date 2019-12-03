using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019 {
	public class Day_2_2 {
		public Day_2_2() {
			string program = File.ReadAllText("inputs/exercise_2_2.txt");

			List<int> operands;

			for (int noun = 0; noun < 100; noun++) {
				for (int verb = 0; verb < 100; verb++) {
					operands = program.Split(',').Select((elt) => int.Parse(elt)).ToList();

					operands[1] = noun;
					operands[2] = verb;

					program = String.Join(",", operands.ToArray());

					string result = Day_2_1.ComputeProgram(program);

					operands = result.Split(',').Select((elt) => int.Parse(elt)).ToList();

					if (operands[0] == 19690720) {
						Console.WriteLine("Day 2 - Exercise 2: " + (100 * noun + verb));
					}
				}
			}
		}
	}
}
