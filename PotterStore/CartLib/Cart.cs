using System;
using System.Collections.Generic;

namespace CartLib
{
	public class Cart
	{
		private List<Book> _BookCart = new List<Book>();
		public Cart()
		{
		}

		public object GetPrice()
		{
			return 0;
		}

		public void Add(Book book)
		{
			_BookCart.Add(book);
		}
	}
}