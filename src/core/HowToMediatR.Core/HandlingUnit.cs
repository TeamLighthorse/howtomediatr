using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class HandlingUnit : ValueObject
	{
		public int Quantity { get; private set; }
		public PackagingType PackagingType { get; private set; }
		public Dimensions Dimensions { get; private set; }
		public bool IsStackable { get; private set; }
		protected override ITuple AsTuple() => (Quantity, PackagingType, Dimensions, IsStackable);
	}
}