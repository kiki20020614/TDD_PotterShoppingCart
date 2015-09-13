using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Books
    {
        public void CalculatePrice(ViewModelBooks books)
        {
            int oriPrice = 100;

            //Get min Buy Qty
            int minBuyQty = books.BookQty
                .Select((v, i) => new { Index = i, Value = v })
                .Where(r => r.Value > 0)
                .Select(r => r.Value)
                .FirstOrDefault();

            if (minBuyQty != 0)
            {
                //Sort
                books.BookQty = books.BookQty.OrderBy(r => r).ToArray();

                var calcBuyDiscountQty = 0;
                for (int i = 0; i < books.BookQty.Count(); i++)
                {
                    int qty = books.BookQty[i];
                    if (qty < minBuyQty) continue;

                    books.BookQty[i] = books.BookQty[i] - minBuyQty;
                    calcBuyDiscountQty++;
                }

                double discount = GetDiscount(calcBuyDiscountQty);
                books.Price += Convert.ToInt32(oriPrice * calcBuyDiscountQty * discount);

                CalculatePrice(books);
            }
        }

        private static double GetDiscount(int DiscountQty)
        {
            double discount = 0;
            if (DiscountQty == 2)
                discount = 0.95;
            else if (DiscountQty == 3)
                discount = 0.9;
            else if (DiscountQty == 4)
                discount = 0.8;
            else if (DiscountQty == 5)
                discount = 0.75;
            else
                discount = 1;

            return discount;
        }   
    }
}
