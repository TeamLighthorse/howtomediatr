using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class Address : ValueObject
	{
		public Address(string line1, string line2, string line3, string city, string stateAbbreviation, string postalCode)
		{
			Line1 = line1;
			Line2 = line2;
			Line3 = line3;
			City = city;
			StateAbbreviation = stateAbbreviation;
			PostalCode = postalCode;
		}

		public string Line1 { get; }
		public string Line2 { get; }
		public string Line3 { get; }
		public string City { get; }
		public string StateAbbreviation { get; }
		public string PostalCode { get; }
		protected override ITuple AsTuple() => (Line1, Line2, Line3, City, StateAbbreviation, PostalCode);
	}
}