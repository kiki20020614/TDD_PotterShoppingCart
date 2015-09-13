using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using System.Collections;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CalculateDiscountTests
    {
        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Price_100()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 100;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_one_Price_190()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1 , 1 }
            };

            //act
            target.CalculatePrice(booksInfo);
            
            //assert
            var expected = 190;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_one_Book3_Buy_one_Price_270()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1, 1, 1 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 270;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_one_Book3_Buy_one_Book4_Buy_one_Price_320()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1, 1, 1, 1 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 320;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_one_Book3_Buy_one_Book4_Buy_one_Book5_Buy_one_Price_375()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1, 1, 1, 1, 1 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 375;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_one_Book3_Buy_two_Price_370()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1, 1, 2 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 370;
            Assert.AreEqual(expected, booksInfo.Price);
        }

        [TestMethod()]
        public void CalculateTest_Book1_Buy_one_Book2_Buy_two_Book3_Buy_two_Price_460()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 1, 2, 2 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 460;
            Assert.AreEqual(expected, booksInfo.Price);
        }




        [TestMethod()]
        public void CalculateTest_Book1_Buy_two_Book2_Buy_five_Book3_Buy_three_Book4_Buy_Four_Book5_Buy_Two_Price_935()
        {
            //arrange
            var target = new Books();
            var booksInfo = new ViewModelBooks
            {
                BookQty = new int[] { 2, 5, 3, 4, 2 }
            };

            //act
            target.CalculatePrice(booksInfo);

            //assert
            var expected = 935;
            Assert.AreEqual(expected, booksInfo.Price);
        }
    }
}
