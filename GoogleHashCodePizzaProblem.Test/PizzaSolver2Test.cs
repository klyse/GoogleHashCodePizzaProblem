using System;
using System.IO;
using GoogleHashCodePizzaProblem.Algorithms;
using GoogleHashCodePizzaProblem.Model;
using NUnit.Framework;

namespace GoogleHashCodePizzaProblem.Test
{
	public class PizzaSolver2Test
	{
		[Test]
		[TestCase("a_example.in")]
		[TestCase("b_small.in")]
		[TestCase("c_medium.in")]
		[TestCase("d_big.in")]
		public void PizzaSolver2(string example)
		{
			var pizzaInput = new PizzaInput().Load(Path.Combine(EnvironmentConstants.InputPath, example));

			var pizzaOutput = new PizzaSolver2().Execute(pizzaInput);

			pizzaOutput.Save(Path.Combine(EnvironmentConstants.OutputPath, "PizzaSolver2", pizzaInput.FileName));

			Console.WriteLine($"Total Score: {pizzaOutput.TotalScore}");

			Assert.Pass();
		}
	}
}