using Xunit;

namespace AdventOfCode2019.Tests {
	public class Day_1_1_Tests {
		[Theory]
		[InlineData(12, 2)]
		[InlineData(14, 2)]
		[InlineData(1969, 654)]
		[InlineData(100756, 33583)]
		public void Mass_X_Should_Return_Y(int mass, int fuel) {
			Assert.Equal(
				Day_1_1.CalcFuelFromMass(mass),
				fuel
			);
		}
	}
}
