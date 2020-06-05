namespace HowToMediatR.Core
{
	public sealed class FreightClass
	{
		public static readonly FreightClass Class50 = new FreightClass("50");
		public static readonly FreightClass Class55 = new FreightClass("55");
		public static readonly FreightClass Class60 = new FreightClass("60");
		public static readonly FreightClass Class65 = new FreightClass("65");
		public static readonly FreightClass Class70 = new FreightClass("70");
		public static readonly FreightClass Class77_5 = new FreightClass("77.5");
		public static readonly FreightClass Class85 = new FreightClass("85");
		public static readonly FreightClass Class92_5 = new FreightClass("92.5");
		public static readonly FreightClass Class100 = new FreightClass("100");
		public static readonly FreightClass Class110 = new FreightClass("110");
		public static readonly FreightClass Class125 = new FreightClass("125");
		public static readonly FreightClass Class150 = new FreightClass("150");
		public static readonly FreightClass Class175 = new FreightClass("175");
		public static readonly FreightClass Class200 = new FreightClass("200");
		public static readonly FreightClass Class250 = new FreightClass("250");
		public static readonly FreightClass Class300 = new FreightClass("300");
		public static readonly FreightClass Class400 = new FreightClass("400");
		public static readonly FreightClass Class500 = new FreightClass("500");

		private FreightClass(string value) => Value = value;

		public string Value { get; }

		public static FreightClass Parse(string str)
		{
			switch (str)
			{
				case "50": return Class50;
				case "55": return Class55;
				case "60": return Class60;
				case "65": return Class65;
				case "70": return Class70;
				case "77.5": return Class77_5;
				case "85": return Class85;
				case "92.5": return Class92_5;
				case "100": return Class100;
				case "110": return Class110;
				case "125": return Class125;
				case "150": return Class150;
				case "175": return Class175;
				case "200": return Class200;
				case "250": return Class250;
				case "300": return Class300;
				case "400": return Class400;
				case "500": return Class500;
				default: return null;
			}
		}

		public static implicit operator FreightClass(string str) => Parse(str);
		public static implicit operator string(FreightClass freightClass) => freightClass?.Value;
	}
}