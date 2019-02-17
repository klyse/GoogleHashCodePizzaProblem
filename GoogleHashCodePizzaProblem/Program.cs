using System.IO;
using GoogleHashCodePizzaProblem.Algorithms;
using GoogleHashCodePizzaProblem.Model;

namespace GoogleHashCodePizzaProblem
{
	public class Program
	{
		static void Main()
		{
			var pizzaInput = new PizzaInput().Load(Path.Combine(EnvironmentConstants.InputPath, "a_example.in"));

			var pizzaOutput = new PizzaSolver2().Execute(pizzaInput);

			pizzaOutput.Save(Path.Combine(EnvironmentConstants.OutputPath, pizzaInput.FileName));
		}
	}
}