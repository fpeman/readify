using System;
using System.ServiceModel;

namespace KnockKnock.SampleRedPillService
{
	public class RedPill : IRedPill
	{
		public long FibonacciNumber(long n)
		{
			long output;

			try
			{
				output = Fibonacci.ValueAt(n);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
			}

			return output;
		}

		public string ReverseWords(string s)
		{
			return Words.Reverse(s);
		}

		public Shapes.TriangleType WhatShapeIsThis(int a, int b, int c)
		{
			return Shapes.WhatIsthis(a, b, c);
		}

		public ContactDetails WhoAreYou()
		{
			var details = new ContactDetails
			{
				EmailAddress = "fpeman@gmail.com",
				FamilyName = "yang",
				GivenName = "lu",
				PhoneNumber = "+61 423 343 889"
			};

			return details;
		}


        public System.Guid WhatIsYourToken()
        {
            return System.Guid.Parse("e196fac5-5875-4cd6-bbe2-ef55043b93bd");
        }
    }
}
