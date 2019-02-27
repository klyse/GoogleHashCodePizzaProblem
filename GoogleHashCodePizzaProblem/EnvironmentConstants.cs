using System;
using System.IO;

namespace GoogleHashCodePizzaProblem
{
	public static class EnvironmentConstants
	{
		public static string EnvironmentVariable { get; } = "HashCodePizzaWorkingDir";
		public static string DataPath => Environment.GetEnvironmentVariable(EnvironmentVariable);
		public static string InputPath => Path.Combine(DataPath, "Input");
		public static string OutputPath => Path.Combine(DataPath, "Output");
	}
}
