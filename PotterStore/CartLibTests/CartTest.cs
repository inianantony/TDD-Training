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

		[TestMethod()]
		public void GetPrice_Return_100_When_There_Is_A_Book_In_Cart()
		{
			var cart = new Cart();
			cart.Add(new Book { BookName = "book1", Price = 100});
			var expected = 100;

			var actual = cart.GetPrice();
			
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void GetPrice_Return_200_When_There_Are_2_Books_In_Cart()
		{
			var cart = new Cart();
			cart.Add(new Book { BookName = "book1", Price = 100 });
			cart.Add(new Book { BookName = "book1", Price = 100 });
			var expected = 200;

			var actual = cart.GetPrice();

			Assert.AreEqual(expected, actual);
		}
	}
}
