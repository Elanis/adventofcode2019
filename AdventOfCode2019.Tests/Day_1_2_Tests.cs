using Xunit;

namespace AdventOfCode2019.Tests {
	public class Day_1_2_Tests {
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
