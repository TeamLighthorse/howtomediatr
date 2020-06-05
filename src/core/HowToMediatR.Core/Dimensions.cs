using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class Dimensions : ValueObject
	{
		public Dimensions(double length, double width, double height)
		{
			Length = length;
			Width = width;
			Height = height;
		}

		public double Length { get; }
		public double Width { get; }
		public double Height { get; }
		protected override ITuple AsTuple() => (Length, Width, Height);
	}
}