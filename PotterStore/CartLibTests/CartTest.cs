using CartLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartLibTests
{
	[TestClass()]
	public class CartTest
	{
		[TestMethod()]
		public void GetPrice_Return_0_When_There_Are_No_Books()
		{
			var cart = new Cart();
			var expected = 0;

			var actual = cart.GetPrice();

			Assert.AreEqual(expected, actual);

		}
	}
}
