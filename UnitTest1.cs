using MyMethodCountingLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMethodCountingLibTesting
{
	[TestClass]
	public class MyMethodCountingTest
	{
		// 1 test
		[TestMethod]
		public void Sum_10and20_30returned()
		{
			// arrange
			int x = 10;
			int y = 20;
			int expected = 30;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 2 test
		[TestMethod]
		public void Sum_00and18_18returned()
		{
			// arrange
			int x = 0;
			int y = 18;
			int expected = 18;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 3 test
		[TestMethod]
		public void Sum_10NotAnd20_Not10returned()
		{
			// arrange
			int x = 10;
			int y = -20;
			int expected = -10;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 4 test
		[TestMethod]
		public void Sum_123and321_444returned()
		{
			// arrange
			int x = 123;
			int y = 321;
			int expected = 444;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 5 test
		[TestMethod]
		public void Sum_1and2_3returned()
		{
			// arrange
			int x = 1;
			int y = 2;
			int expected = 3;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 6 test
		[TestMethod]
		public void NotSum_5and5_11returned()
		{
			// arrange
			int x = 5;
			int y = 5;
			int expected = 11;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreNotEqual(expected, actual);
		}

		// 7 test
		[TestMethod]
		public void Sum_5891and3427_9318returned()
		{
			// arrange
			int x = 5891;
			int y = 3427;
			int expected = 9318;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 8 test
		[TestMethod]
		public void Sum_7and2_9returned()
		{
			// arrange
			int x = 7;
			int y = 2;
			int expected = 9;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 9 test
		[TestMethod]
		public void Sum_0and0_0returned()
		{
			// arrange
			int x = 0;
			int y = 0;
			int expected = 0;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}

		// 10 test
		[TestMethod]
		public void Sum_100and200_300returned()
		{
			// arrange
			int x = 100;
			int y = 200;
			int expected = 300;

			// act
			MyMethodCounting c = new MyMethodCounting();
			int actual = c.Sum(x, y);

			// assert
			Assert.AreEqual(expected, actual);
		}
	}
}
