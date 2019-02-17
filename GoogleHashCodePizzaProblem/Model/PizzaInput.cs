﻿using System.Linq;
using GoogleHashCodePizzaProblem.Base;
using NeoMatrix;

namespace GoogleHashCodePizzaProblem.Model
{
	public class PizzaInput : Input<PizzaInput>
	{
		public enum CellType
		{
			Tomato,
			Mushroom
		}

		public int MinIngredients { get; set; }
		public int MaxCells { get; set; }

		public Matrix<CellType> Matrix { get; set; }

		public override PizzaInput Parse(string[] input)
		{
			var descriptiveProps = ParseParamLineInt(input[0]);

			var rows = descriptiveProps.ElementAt(0);
			var columns = descriptiveProps.ElementAt(1);
			MinIngredients = descriptiveProps.ElementAt(2);
			MaxCells = descriptiveProps.ElementAt(3);

			Matrix = new Matrix<CellType>(rows, columns);

			// set parameters for a valid slice
			PizzaOutput.Slice.MinIngredients = MinIngredients;
			PizzaOutput.Slice.MaxCells = MaxCells;

			for (var i = 1; i < input.Length; i++)
			{
				var row = i - 1;
				var rowData = input[i];
				for (var j = 0; j < rowData.Length; j++)
					if (rowData[j] == 'T')
						Matrix[row, j] = CellType.Tomato;
					else
						Matrix[row, j] = CellType.Mushroom;
			}

			PizzaOutput.Slice.TotalTomatoes = Matrix.GetFlat().Count(c => c == CellType.Tomato);
			PizzaOutput.Slice.TotalMushrooms = Matrix.TotalCount - PizzaOutput.Slice.TotalTomatoes;

			return this;
		}
	}
}