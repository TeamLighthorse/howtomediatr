using System;
using System.Linq;
using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class PackagingType : ValueObject
	{
		public static PackagingType Skid = new PackagingType("Skid", "SKID");
		public static PackagingType Box = new PackagingType("Box", "BOX");
		public static PackagingType Crate = new PackagingType("Crate", "CRATE");
		public static PackagingType Bag = new PackagingType("Bag", "BAG");
		public static PackagingType Drum = new PackagingType("Drum", "Drum");

		private PackagingType(string name, string code)
		{
			Name = name;
			Code = code;
		}

		public string Name { get; }
		public string Code { get; }

		public static PackagingType[] List()
			=> new[] { Skid, Box, Crate, Bag, Drum };

		public static PackagingType FromCode(string code)
			=> List().Single(_ => _.Code.Equals(code, StringComparison.InvariantCultureIgnoreCase));

		protected override ITuple AsTuple() => (Name, Code);
		public override string ToString() => Code;

		public static implicit operator PackagingType(string code) => FromCode(code);
		public static implicit operator string(PackagingType code) => code?.ToString();
	}
}