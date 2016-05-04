using System.Linq;
using System.Collections.Generic;

namespace CartLib
{
	public class Cart
	{
		private List<Book> _BookCart = new List<Book>();
		public Cart()
		{
		}

		public decimal GetPrice()
		{
			if(!_BookCart.Any())
				return 0;
			return 100;
		}

		public void Add(Book book)
		{
			_BookCart.Add(book);
		}
	}
}