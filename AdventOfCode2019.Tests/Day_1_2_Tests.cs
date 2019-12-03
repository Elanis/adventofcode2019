using Xunit;

namespace AdventOfCode2019.Tests {
	public class Day_1_2_Tests {
		[Theory]
		[InlineData(12, 2)]
		[InlineData(14, 2)]
		[InlineData(1969, 654)]
		[InlineData(100756, 33583)]
		public void CalcFuelFromMass_X_Should_Return_Y(int mass, int fuel) {
			Assert.Equal(
				Day_1_1.CalcFuelFromMass(mass),
				fuel
			);
		}

		[Theory]
		[InlineData(14, 2)]
		[InlineData(1969, 966)]
		[InlineData(100756, 50346)]
		public void CalcFinalFuelFromMass_X_Should_Return_Y(int mass, int fuel) {
			Assert.Equal(
				Day_1_2.CalcFinalFuelFromMass(mass),
				fuel
			);
		}
	}
}
