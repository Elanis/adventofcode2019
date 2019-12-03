using Xunit;

namespace AdventOfCode2019.Tests {
	public class Day_2_1_Tests {
		[Theory]
		[InlineData("1,0,0,0,99", "2,0,0,0,99")]
		[InlineData("2,3,0,3,99", "2,3,0,6,99")]
		[InlineData("2,4,4,5,99,0", "2,4,4,5,99,9801")]
		[InlineData("1,1,1,4,99,5,6,0,99", "30,1,1,4,2,5,6,0,99")]
		public void ComputeProgram_X_Should_Return_Y(string program, string result) {
			Assert.Equal(
				Day_2_1.ComputeProgram(program),
				result
			);
		}
	}
}
