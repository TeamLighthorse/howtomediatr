using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class Location : ValueObject
	{
		public Location(Contact contact, Address address)
		{
			Contact = contact;
			Address = address;
		}

		public Contact Contact { get; }
		public Address Address { get; }
		protected override ITuple AsTuple() => (Contact, Address);
	}
}