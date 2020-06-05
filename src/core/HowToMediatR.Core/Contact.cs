using System.Runtime.CompilerServices;
using HowToMediatR.Core.Kernel;

namespace HowToMediatR.Core
{
	public class Contact : ValueObject
	{
		public Contact(string name, string phone, string email)
		{
			Name = name;
			Phone = phone;
			Email = email;
		}

		public string Name { get; }
		public string Phone { get; }
		public string Email { get; }
		protected override ITuple AsTuple() => (Name, Phone, Email);
	}
}